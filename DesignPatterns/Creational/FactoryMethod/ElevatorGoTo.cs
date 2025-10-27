namespace DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorGoTo : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Elevator will go to floor {floor}");
        }
    }
}
