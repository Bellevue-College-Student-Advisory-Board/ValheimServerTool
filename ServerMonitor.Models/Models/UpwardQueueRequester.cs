using System;
using System.Net;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace ServerMonitor.Models.Models
{
    public class UpwardQueueRequester
    {
        private readonly string UPWARD_QUEUE_URL = @"https://sqs.us-west-2.amazonaws.com/124704454835/ServerManager-Upward-Queue";
        private AWSCredentials _awsCredentials;
        private Guid _sessionID;

        public UpwardQueueRequester(AWSCredentials awsCredentials, Guid guid)
        {
            _awsCredentials = awsCredentials;
            _sessionID = guid;
        }

        public async void RequestServerStatus()
        {
            string body = $"{{ \"type\": \"status\"}}";

            using (AmazonSQSClient sqsClient = new AmazonSQSClient(_awsCredentials))
            {
                SendMessageRequest request = new SendMessageRequest(UPWARD_QUEUE_URL, body);

                MessageAttributeValue value;
                value = new MessageAttributeValue
                {
                    DataType = "String",
                    StringValue = _sessionID.ToString()
                };

                request.MessageAttributes.Add("request-id", value);
                SendMessageResponse response = await sqsClient.SendMessageAsync(request);

                if (response.HttpStatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("Message received");
                }
                else
                {
                    Console.WriteLine("Could not send message for some reason");
                }
            }
        }
    }
}