using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using ServerMonitor.Models.Presenters;
using ServerMonitor.Models.Views;

namespace ServerMonitor
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainView mainView = new MainView();
            IServerView serverView = new ServerView();

            IServerPresenter serverPresenter = new ServerPresenter(serverView);
            IMainPresenter mainPresenter = new MainPresenter(mainView, serverPresenter);

            Application.Run((MainView)mainView);
        }
    }
}
