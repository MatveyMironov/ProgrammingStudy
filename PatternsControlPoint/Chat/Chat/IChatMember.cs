using System;

namespace Chat
{
    internal interface IChatMember
    {
        event Action<string> OnMessageSend;

        void SendMessage(string message);
        void RecieveMessage(string message);
    }
}
