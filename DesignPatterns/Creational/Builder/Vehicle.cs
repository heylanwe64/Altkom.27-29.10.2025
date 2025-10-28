namespace DesignPatterns.Creational.Builder
{
    internal class Vehicle : ICloneable
    {
        //builder może występować jako klasa zagnieżdżona
        //blokujemy tworzenie obiektów klasy Vehicle bezpośrednio
        //i wymuszamy korzystanie z buildera
        /*private Vehicle() { }
        public class Builder
        {
            private readonly Vehicle _vehicle = new Vehicle();
            //implementacja wzorca Builder
        }*/

        public Vehicle() { }

        public Vehicle(int wheels, int seats)
        {
            Wheels = wheels;
            Seats = seats;
        }

        public Vehicle(int wheels, int seats, int? trunkCapacity) : this(wheels, seats)
        {
            TrunkCapacity = trunkCapacity;
        }

        public Vehicle(int wheels, int? enginePower, int seats) : this(wheels, seats)
        {
            EnginePower = enginePower;
        }

        public Vehicle(int wheels, int seats, int doors, int? trunkCapacity, int? enginePower) : this(wheels, seats)
        {
            Doors = doors;
            TrunkCapacity = trunkCapacity;
            EnginePower = enginePower;
        }


        public int Wheels { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int? TrunkCapacity { get; set; }
        public int? EnginePower { get; set; }


        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Wheels: {Wheels}, Seats: {Seats}, Doors: {Doors}, TrunkCapacity: {TrunkCapacity}, EnginePower: {EnginePower}";
        }
    }
}
