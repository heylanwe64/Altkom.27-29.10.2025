using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    internal class Client
    {
        public static void Execute()
        {
            var user = new ChatUser { Nick = "Paul" };
            var bot1 = new ChatBot { Nick = "Siri" };
            var bot2 = new ChatBot { Nick = "Cortana" };

            var chat = new Chat();
            user.Mediator = chat;
            bot1.Mediator = chat;
            bot2.Mediator = chat;

            while (true)
            {
                var message = Console.ReadLine();
                var splittedMessage = message?.Split(" $ ", 2);

                if(splittedMessage.Length > 1)
                {
                    user.Mediator?.Send(user, splittedMessage[0], splittedMessage[1]);
                }
                else
                {
                    user.Mediator?.Send(user, message);
                }
            }
        }
    }
}
