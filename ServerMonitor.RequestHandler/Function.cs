using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;
using Amazon.SQS;
using Amazon.SQS.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ServerMonitor.RequestHandler
{
    public class Function
    {
        const string DOWNWARD_QUEUE_URL = @"https://sqs.us-west-2.amazonaws.com/124704454835/ServerManager-Downward-Queue";
        protected struct ServerResponse
        {
            public string Type { get; private set; }
            public string Status { get; private set; }
            public string IPv4 { get; private set; }

            public ServerResponse(string type, string status, string ipv4)
            {
                Type = type;
                Status = status;
                IPv4 = ipv4;
            }
        }

        /// <summary>
        /// Default constructor. This constructor is used by Lambda to construct the instance. When invoked in a Lambda environment
        /// the AWS credentials will come from the IAM role associated with the function and the AWS region will be set to the
        /// region the Lambda function is executed in.
        /// </summary>
        public Function()
        {

        }

           
        /// <summary>
        /// This method is called for every Lambda invocation. This method takes in an SQS event object and can be used 
        /// to respond to SQS messages.
        /// </summary>
        /// <param name="sqsEvent"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task FunctionHandler(SQSEvent sqsEvent, ILambdaContext context)
        {
            foreach(var message in sqsEvent.Records)
            {
                await ProcessMessageAsync(message, context);
            }
        }

        private async Task ProcessMessageAsync(SQSEvent.SQSMessage message, ILambdaContext context)
        {
            string type = ParseJSONRequest(message);
            
            message.MessageAttributes.TryGetValue("request-id", out SQSEvent.MessageAttribute id);
            string body = CreateJSONResponse(CreateResponse(type));
            EnqueueMessage(body, id);
            
            context.Logger.LogLine($"Processed message {message.Body}");
            await Task.CompletedTask;
        }

        private string ParseJSONRequest(SQSEvent.SQSMessage message)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(message.Body));
            JObject jsonObject = JObject.Load(reader);

            string type = (string)jsonObject["type"];
            return type;
        }

        private string CreateJSONResponse(ServerResponse serverResponse)
        {
            string preformattedJSON = $"{{ \"type\": \"{serverResponse.Type}\", " +
                                      $"\"status\": \"{serverResponse.Status}\", " +
                                      $"\"ip\": \"{serverResponse.IPv4}\"}}";

            return preformattedJSON;
        }


        private void EnqueueMessage(string body, SQSEvent.MessageAttribute id)
        {
            using (AmazonSQSClient sqsClient = new AmazonSQSClient())
            {
                SendMessageRequest request = new SendMessageRequest(DOWNWARD_QUEUE_URL, body);

                MessageAttributeValue value;
                if (id != null)
                {
                    value = new MessageAttributeValue
                    {
                        DataType = "String",
                        StringValue = id.StringValue
                    };

                    
                }
                else
                {
                    value = new MessageAttributeValue
                    {
                        DataType = "String",
                        StringValue = "-1"
                    };
                }

                request.MessageAttributes.Add("request-id", value);
                Task<SendMessageResponse> response = sqsClient.SendMessageAsync(request);

                if (response.Result.HttpStatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("Message sent");
                }
                else
                {
                    Console.WriteLine("Could not send message for some reason");
                }
            }
        }

        private ServerResponse CreateResponse(string type)
        {
            switch (type)
            {
                case "status":
                    return GetServerStatus();
                case "launch":
                    return LaunchServer();
                case "close":
                    return CloseServer();
                default:
                    return new ServerResponse(null, "stopped", "0.0.0.0");
            }
        }

        private ServerResponse GetServerStatus()
        {
            using (AmazonEC2Client ec2Client = new AmazonEC2Client())
            {
                DescribeInstancesRequest instancesRequest = new DescribeInstancesRequest()
                {
                    InstanceIds = new List<string> { "i-05f9d91ae6210ce14" }
                };

                Task<DescribeInstancesResponse> instancesResponse = ec2Client.DescribeInstancesAsync(instancesRequest);

                string state = instancesResponse.Result.Reservations[0].Instances[0].State.Name;
                string ip = instancesResponse.Result.Reservations[0].Instances[0].PublicIpAddress;

                return new ServerResponse("status", state, ip);
            }
        }

        private ServerResponse LaunchServer()
        {
            return new ServerResponse(null, null, null);
        }

        private ServerResponse CloseServer()
        {
            return new ServerResponse(null, null, null);
        }
    }
}
