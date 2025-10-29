namespace DesignPatterns.Behavioral.Command
{
    internal interface ICommand
    {
        bool Execute();
        void Undo();
    }
}
