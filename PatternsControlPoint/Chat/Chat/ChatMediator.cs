using System.Collections.Generic;

namespace Chat
{
    internal class ChatMediator : IChatMediator
    {
        private List<IChatMember> _members;

        public ChatMediator()
        {
            _members = new List<IChatMember>();
        }

        public void RegisterChatMember(IChatMember chatMember)
        {
            _members.Add(chatMember);
            chatMember.OnMessageSend += SendMessageToAll;
        }

        public void SendMessageToAll(string message)
        {
            foreach (var member in _members)
            {
                member.RecieveMessage(message);
            }
        }
    }
}
