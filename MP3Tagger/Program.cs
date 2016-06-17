using System;
using System.Windows.Forms;
using BusinessLogic;

namespace MP3Tagger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var mainView = new MainForm();
            var messageService = new MessageService();
            var tracksManager = new TracksManager();
            var mainController = new MainController(tracksManager, messageService, mainView);

            Application.Run(mainView);
            
        }
    }
}
