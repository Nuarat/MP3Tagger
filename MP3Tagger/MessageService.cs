using System.Windows.Forms;
using BusinessLogic.ViewInterfaces;

namespace MP3Tagger
{
    /// <summary>
    /// Used to show errors, warnings and notifications in WinForms
    /// </summary>
    public class MessageService : IMessageService{

        private const string NOTIFICATION = "Notification";
        private const string WARNING = "Warning";
        private const string ERROR = "Error";


        /// <summary>
        /// Displays to a user a message of "notification" type
        /// </summary>
        /// <param name="notification"></param>
        public void ShowNotification(string notification){
            MessageBox.Show(notification, NOTIFICATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Displays to a user a message of "warning" type
        /// </summary>
        /// <param name="warning"></param>
        public void ShowWarning(string warning){
            MessageBox.Show(warning, WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Displays to a user a message of "error" type
        /// </summary>
        /// <param name="error"></param>
        public void ShowError(string error){
            MessageBox.Show(error, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
