namespace DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorUp : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Elevator will stop at floor {floor} going UP");
        }
    }
}
