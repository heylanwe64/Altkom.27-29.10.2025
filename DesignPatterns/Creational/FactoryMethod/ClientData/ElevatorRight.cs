namespace DesignPatterns.Creational.FactoryMethod.ClientData
{
    internal class ElevatorRight : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Elevator will move to the RIGHT {floor} station");
        }
    }
}