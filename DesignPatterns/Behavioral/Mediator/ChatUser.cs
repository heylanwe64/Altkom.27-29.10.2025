namespace DesignPatterns.Behavioral.Mediator
{
    internal class ChatUser : ChatMemeber
    {
        public override void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Console.WriteLine($"{from} to {Nick}: {message}");
            else
                Console.WriteLine($"{from} to all: {message}");
        }
    }
}
