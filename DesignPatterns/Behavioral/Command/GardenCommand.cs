namespace DesignPatterns.Behavioral.Command
{
    internal abstract class GardenCommand : ICommand
    {
        protected Garden Garden { get; }
        protected string PlantName { get; }
        protected GardenCommand(Garden garden, string plantName)
        {
            Garden = garden;
            PlantName = plantName;
        }

        public abstract bool Execute();
        public abstract void Undo();
    }
}
