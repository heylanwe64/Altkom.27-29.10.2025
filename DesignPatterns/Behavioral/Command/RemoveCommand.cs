namespace DesignPatterns.Behavioral.Command
{
    internal class RemoveCommand : GardenCommand
    {
        public RemoveCommand(Garden garden, string plantName) : base(garden, plantName)
        {
        }
        public override bool Execute()
        {
           return Garden.Remove(PlantName);
        }

        public override void Undo()
        {
            Garden.Add(PlantName);
        }
    }
}


