using System;

namespace Chat
{
    internal class ChatMember : IChatMember
    {
        private readonly string _name;

        public ChatMember(string name)
        {
            _name = name;
        }

        public event Action<string> OnMessageSend;

        public void RecieveMessage(string message)
        {
            Console.WriteLine($"{_name} recieved message: {message}");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{_name} sent message: {message}");
            OnMessageSend?.Invoke(message);
        }
    }
}
