using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServerMonitor.Models.Models
{
    public sealed class ValheimServer : IServer
    {
        const string UNKNOWN_IP = "0.0.0.0";

        private AmazonEC2Client _ec2Client;
        private AWSCredentials _awsCredentials;
        private static ValheimServer _instance;
        private static Guid _SessionID;

        public event EventHandler ServerStateReceived;
        public event EventHandler ServerStarted;
        public event EventHandler ServerShutdown;

        public string IPv4 { get; private set; } = UNKNOWN_IP;
        public string State { get; private set; } = "stopped";

        public static ValheimServer Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new ValheimServer();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Private singleton constructor that constructs a server instance using the given credentials
        /// </summary>
        private ValheimServer()
        {
            _awsCredentials = GetAWSCredentialsByName("valheim");
            _ec2Client = new AmazonEC2Client(_awsCredentials, Amazon.RegionEndpoint.USWest2);
            _SessionID = Guid.NewGuid();
            UpdateServerStats();
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

        private void UpdateServerStats()
        {

            DescribeInstancesRequest instancesRequest = new DescribeInstancesRequest()
            {
                InstanceIds = new List<string> { "i-05f9d91ae6210ce14" }
            };

            Task<DescribeInstancesResponse> instanceResponse = _ec2Client.DescribeInstancesAsync(instancesRequest);

            this.State = instanceResponse.Result.Reservations[0].Instances[0].State.Name;
            this.IPv4 = instanceResponse.Result.Reservations[0].Instances[0].PublicIpAddress;
            ServerStateReceived?.Invoke(new ServerResponse(this.State), EventArgs.Empty);
        }

        /// <summary>
        /// Gets aws credentials for given profile
        /// </summary>
        /// <param name="profileName">The name of the profile</param>
        /// <returns>The AWS credentials for the given profile</returns>
        private static AWSCredentials GetAWSCredentialsByName(string profileName)
        {
            if (string.IsNullOrEmpty(profileName))
            {
                throw new ArgumentNullException("profileName cannot be null or empty");
            }

            SharedCredentialsFile credFile = new SharedCredentialsFile();
            CredentialProfile profile = credFile.ListProfiles().Find(p => p.Name.Equals(profileName));

            if (profile is null)
            {
                throw new Exception($"Profile named {profileName} not found");
            }

            return AWSCredentialsFactory.GetAWSCredentials(profile, new SharedCredentialsFile());

        }
    }
}
