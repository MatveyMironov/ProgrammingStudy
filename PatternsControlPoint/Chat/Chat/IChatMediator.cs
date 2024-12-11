namespace Chat
{
    internal interface IChatMediator
    {
        void RegisterChatMember(IChatMember chatMember);

        void SendMessageToAll(string message);
    }
}
