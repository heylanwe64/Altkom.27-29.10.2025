using DesignPatterns.Creational.FactoryMethod.ClientData;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            //var elevator = new Elevator();
            var elevator = new HorizontalElevator();

            var request = new Request("UP", 5);
            elevator.Execute(request.Operation, request.Floor);


            request = new Request("GOTO", 5);
            elevator.Execute(request.Operation, request.Floor);



            request = new Request("Left", 2);
            elevator.Execute(request.Operation, request.Floor);

        }


        record Request(string Operation, int Floor);
    }

    class HorizontalElevator : Elevator
    {
        protected override IElevatorOperation? CreateOperation(string operation)
        {
            return operation.ToUpper() switch
            {
                "LEFT" => new ElevatorLeft(),
                "RIGHT" => new ElevatorRight(),
                _ => base.CreateOperation(operation)
            };
        }
    }
}
