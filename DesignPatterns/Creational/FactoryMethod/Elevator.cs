namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Elevator
    {
        public void Execute(IElevatorOperation operation, int floor)
        {
            operation.Operate(floor);
        }
    }
}
