namespace DesignPatterns.Behavioral.Mediator
{
    internal abstract class ChatMemeber
    {
        private IMediator? mediator;
        public IMediator? Mediator
        {
            get => mediator;
            set
            {
                if (mediator != null)
                    mediator.Quit(this);
                mediator = value;
                if (mediator != null)
                    mediator.Join(this);
            }
        }
        public string Nick { get; set; }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}