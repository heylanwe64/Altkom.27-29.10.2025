namespace DesignPatterns.Behavioral.Mediator
{
    internal class ChatBot : ChatMemeber
    {
        public override void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Mediator?.Send(this, from, message);
            else
                Mediator?.Send(this, message);
        }
    }
}
