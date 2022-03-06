namespace ConsoleApp.TestMessanger
{
    public class Messenger
    {
        private string userName;
        public Messenger(string userName)
        {
            this.userName = userName;
        }

        public void SendMessage(Messenger messenger, string msg)
        {
            TinyMessageCenter.Send(this.userName, messenger.userName, msg);
        }

        public string ReceiveMessage()
        {
            Message message = TinyMessageCenter.Read(this.userName);
            string receivedMsg = $"Message From {message.From} to {message.To} : {message.Content} ({message.Time})";

            return receivedMsg;
        }
    }
}
