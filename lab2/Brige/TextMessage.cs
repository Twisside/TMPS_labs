namespace Bridge
{
    public class TextMessage : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("TextMessage: " + message);
        }
    }
}