using System;

namespace Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChatMediator mediator = new ChatMediator();

            ChatMember member1 = new ChatMember("member 1");
            ChatMember member2 = new ChatMember("member 2");
            ChatMember member3 = new ChatMember("member 3");

            mediator.RegisterChatMember(member1);
            mediator.RegisterChatMember(member2);
            mediator.RegisterChatMember(member3);

            member1.SendMessage("Hello!");
            member3.SendMessage("Hi!");

            Console.ReadLine();
        }
    }
}
