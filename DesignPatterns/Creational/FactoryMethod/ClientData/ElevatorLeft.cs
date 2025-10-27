namespace DesignPatterns.Creational.FactoryMethod.ClientData
{
    public class ElevatorLeft : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Elevator will move to the LEFT {floor} station");
        }
    }
}