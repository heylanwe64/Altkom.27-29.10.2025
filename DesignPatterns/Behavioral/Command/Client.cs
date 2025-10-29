namespace DesignPatterns.Behavioral.Command
{
    internal class Client
    {
        public static void Execute()
        {
            var garden = new Garden(5);

            var command1 = new PlantCommand(garden, "Róża");
            var command2 = new RemoveCommand(garden, "Róża");
            var command3 = new PlantCommand(garden, "Tulipan");
            var command4 = new RemoveCommand(garden, "Tulipan");

            var plantRoseButton = new CommandInvoker(command1);
            var removeRoseButton = new CommandInvoker(command2);
            var plantTulipButton = new CommandInvoker(command3);
            var removeTulipButton = new CommandInvoker(command4);

            Console.WriteLine(garden);

            plantRoseButton.Invoke();
            plantRoseButton.Invoke();
            plantRoseButton.Invoke();

            Console.WriteLine(garden);

            plantTulipButton.Invoke();
            plantTulipButton.Invoke();
            plantTulipButton.Invoke();

            Console.WriteLine(garden);

            removeRoseButton.Invoke();
            removeTulipButton.Invoke();
            removeTulipButton.Invoke();
            removeTulipButton.Invoke();

            Console.WriteLine(garden);

            CommandInvoker.Reverse();
            CommandInvoker.Reverse();
            CommandInvoker.Reverse();
            CommandInvoker.Reverse();

            Console.WriteLine(garden);
        }
    }
}
