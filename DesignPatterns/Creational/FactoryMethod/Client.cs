namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var request = new Request("UP", 5);

            IElevatorOperation? operation = request.Operation.ToUpper() switch
            {
                "UP" => new ElevatorUp(),
                "DOWN" => new ElevatorDown(),
                _ => null
            };

            if (operation is not null)
            {
                elevator.Execute(operation, request.Floor);
            }
            else
            {
                Console.WriteLine("Invalid operation");

            }

        }


        record Request(string Operation, int Floor);
    }
}
