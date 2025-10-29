namespace DesignPatterns.Behavioral.Mediator
{
    internal interface IMediator
    {
        void Join(ChatMemeber member);
        void Quit(ChatMemeber member);

        void Send(ChatMemeber from, string message);
        void Send(ChatMemeber from, string to, string message);
    }
}
