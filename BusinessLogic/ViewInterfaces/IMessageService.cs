namespace BusinessLogic.ViewInterfaces
{
    /// <summary>
    /// Interface for the Message Service
    /// </summary>
    public interface IMessageService{

        /// <summary>
        /// Displays to a user a message of "notification" type
        /// </summary>
        /// <param name="notification"></param>
        void ShowNotification(string notification);

        /// <summary>
        /// Displays to a user a message of "warning" type
        /// </summary>
        /// <param name="warning"></param>
        void ShowWarning(string warning);

        /// <summary>
        /// Displays to a user a message of "error" type
        /// </summary>
        /// <param name="error"></param>
        void ShowError(string error);


    }
}
