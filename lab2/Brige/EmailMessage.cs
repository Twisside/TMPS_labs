namespace Bridge
{
    public class EmailMessage : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("EmailMessage: " + message);
        }
    }
}