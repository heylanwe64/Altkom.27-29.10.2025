namespace DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorDown : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Elevator will stop at floor {floor} going DOWN");
        }
    }
}
