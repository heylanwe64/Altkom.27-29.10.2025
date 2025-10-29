namespace DesignPatterns.Behavioral.Command
{
    internal class PlantCommand : GardenCommand
    {
        public PlantCommand(Garden garden, string plantName) : base(garden, plantName)
        {
        }

        public override bool Execute()
        {
            return Garden.Add(PlantName);
        }

        public override void Undo()
        {
            Garden.Remove(PlantName);
        }
    }
}
