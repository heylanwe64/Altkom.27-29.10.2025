namespace DesignPatterns.Behavioral.Mediator
{
    internal class Chat : IMediator
    {
        private readonly ICollection<ChatMemeber> _members = [];

        public void Join(ChatMemeber member)
        {
            if (!_members.Contains(member))
                _members.Add(member);
        }

        public void Quit(ChatMemeber member)
        {
            if (_members.Contains(member))
                _members.Remove(member);
        }

        public void Send(ChatMemeber from, string message)
        {
            var query = _members.Where(m => m != from);
            if(from is ChatBot)
                query = query.Where(m => m is not ChatBot);
            foreach (var member in query)
            {
                member.Receive(from.Nick, message, false);
            }
        }

        public void Send(ChatMemeber from, string to, string message)
        {
            var member = _members.FirstOrDefault(m => m.Nick == to);
            member?.Receive(from.Nick, message, true);
        }
    }
}
