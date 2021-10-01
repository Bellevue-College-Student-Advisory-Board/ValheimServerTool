using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using System;
using System.Collections.Generic;

namespace ServerMonitor.Models.Models
{
    public sealed class Server : IServer
    {
        const string UNKNOWN_IP = "0.0.0.0";
        const string UPWARD_QUEUE_URL = @"https://sqs.us-west-2.amazonaws.com/124704454835/ServerManager-Upward-Queue";
        const string DOWNWARD_QUEUE_URL = @"https://sqs.us-west-2.amazonaws.com/124704454835/ServerManager-Upward-Queue";

        private AmazonEC2Client _ec2Client;
        private AWSCredentials _awsCredentials;
        private static Server _instance;
        private static Guid _sessionId;

        public event EventHandler ServerStateReceived;
        public event EventHandler ServerStarted;
        public event EventHandler ServerShutdown;

        public string IPv4 { get; private set; } = UNKNOWN_IP;
        public string State { get; private set; } = "stopped";

        public static Server Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new Server();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Private singleton constructor that constructs a server instance using the given credentials
        /// </summary>
        private Server()
        {
            _awsCredentials = new BasicAWSCredentials
            (
                "AKIAR2CHW7CZ225AWI6R",
                "Oc7++EXyxUxrprkyk9phr8WW6P0s1sa9RcNj7geM"
            );
            _sessionId = Guid.NewGuid();
            UpwardQueueRequester upwardQueue = new  UpwardQueueRequester(_awsCredentials, _sessionId);
            upwardQueue.RequestServerStatus();
        }

        /// <summary>
        /// Starts the server
        /// </summary>
        public async void Start()
        {
            await _ec2Client.StartInstancesAsync(new StartInstancesRequest(new List<string> { "i-05f9d91ae6210ce14" }));

            DescribeInstancesResponse instancesResponse = await _ec2Client.DescribeInstancesAsync();
            this.State = instancesResponse.Reservations[0].Instances[0].State.Name;
            ServerStateReceived?.Invoke(new ServerResponse(this.State), EventArgs.Empty);
           
            bool instanceRunning = this.State.Equals(InstanceStateName.Running);

            while (!instanceRunning)
            {
                instancesResponse = await _ec2Client.DescribeInstancesAsync();
                this.State = instancesResponse.Reservations[0].Instances[0].State.Name;
                ServerStateReceived?.Invoke(instancesResponse, EventArgs.Empty);

                instanceRunning = this.State.Equals(InstanceStateName.Running);
            }

            this.IPv4 = instancesResponse.Reservations[0].Instances[0].PublicIpAddress;
            ServerStarted?.Invoke(new ServerResponse(this.State, this.IPv4), EventArgs.Empty);
            
        }

        /// <summary>
        /// Closes the instance
        /// </summary>
        public async void Close()
        {
            await _ec2Client.StopInstancesAsync(new StopInstancesRequest(new List<string> { "i-05f9d91ae6210ce14" }));

            DescribeInstancesResponse instancesResponse = await _ec2Client.DescribeInstancesAsync();
            this.State = instancesResponse.Reservations[0].Instances[0].State.Name;
            this.IPv4 = UNKNOWN_IP;

            ServerShutdown?.Invoke(new ServerResponse(this.State, this.IPv4), EventArgs.Empty);
        }

    }
}
