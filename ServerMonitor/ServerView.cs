using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using ServerMonitor.Models.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerMonitor
{
    public partial class ServerView : Form, IServerView
    {
        public event EventHandler ServerViewLoaded;
        public event EventHandler ServerViewClosed;
      
        public AWSCredentials AWSCredentials { get; private set; }
        public AmazonEC2Client EC2Client { get; private set; }

        public ServerView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBoxServerIP.TextAlign = HorizontalAlignment.Center;

            AWSCredentials = GetAWSCredentialsByName("valheim");
            EC2Client = new AmazonEC2Client(AWSCredentials, Amazon.RegionEndpoint.USWest2);
        }

        /// <summary>
        /// Starts the EC2 instance
        /// </summary>
        public async void StartInstance()
        {
            await EC2Client.StartInstancesAsync(new StartInstancesRequest(new List<string> { "i-05f9d91ae6210ce14" }));

            DescribeInstancesResponse instancesResponse = await EC2Client.DescribeInstancesAsync();

            bool instanceRunning = instancesResponse.Reservations[0].Instances[0].State.Name == InstanceStateName.Running;

            labelInstanceState.Text = instancesResponse.Reservations[0].Instances[0].State.Name.ToString().ToUpper();

            while (!instanceRunning)
            {
                instancesResponse = await EC2Client.DescribeInstancesAsync();

                instanceRunning = instancesResponse.Reservations[0].Instances[0].State.Name == InstanceStateName.Running;

                labelInstanceState.Text = instancesResponse.Reservations[0].Instances[0].State.Name.ToString().ToUpper();
            }

            textBoxServerIP.Text = instancesResponse.Reservations[0].Instances[0].PublicIpAddress;

        }


        /// <summary>
        /// Stops the EC2 Instance
        /// </summary>
        public async void StopInstance()
        {
            await EC2Client.StopInstancesAsync(new StopInstancesRequest(new List<string> { "i-05f9d91ae6210ce14" }));
        }

        private void ServerView_Load(object sender, EventArgs e)
        {
            ServerViewLoaded?.Invoke(sender, e);
        }

        private void ServerView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServerViewClosed?.Invoke(sender, e);
        }

        
        private void ServerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerViewClosed?.Invoke(sender, e);
            e.Cancel = true;
        }

        private void buttonCopyClipboard_Click(object sender, EventArgs e)
        {
            buttonCopyClipboard.Text = "COPIED";
            Clipboard.SetText(textBoxServerIP.Text);
            buttonCopyClipboard.Text = "COPY TO CLIPBOARD";
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
