namespace SOLID.L
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }


    class Airplane : Vehicle
    {
        public override void Move()
        {
            Fly();
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }

    class Car : Vehicle
    {
        public override void Move()
        {
            Drive();
        }

        public void Drive()
        {
            Console.WriteLine("I am driving!");
        }
    }
}
