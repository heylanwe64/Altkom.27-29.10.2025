namespace DesignPatterns.Behavioral.Command
{
    internal class CommandInvoker
    {
        private readonly ICommand _command;
        private readonly static Stack<ICommand> _commandHistory = new();

        public CommandInvoker(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            if (_command.Execute())
            {
                _commandHistory.Push(_command);
            }
        }

        public static void Reverse()
        {
            if (_commandHistory.TryPop(out var command))
            {
                command.Undo();
            }
        }
    }
}
