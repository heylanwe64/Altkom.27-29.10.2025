namespace DesignPatterns.Behavioral.Memento
{
    internal class Client
    {
        public static void Execute()
        {
            var person = new Person();

            //var caretaker = new Caretaker<Person>(person);
            var caretaker = new AutoCaretaker<Person>(person);

            person.FirstName = "John";
            person.LastName = "Doe";
            Console.WriteLine(person);
            //caretaker.SaveState();

            Thread.Sleep(1500);

            person.FirstName = "Jane";
            Console.WriteLine(person);
            //caretaker.SaveState();

            Thread.Sleep(1500);

            person.LastName = "Smith";
            Console.WriteLine(person);
            //caretaker.SaveState();

            Thread.Sleep(1500);

            person.FirstName = "Emily";
            Console.WriteLine(person);

            caretaker.RestoreState();
            Console.WriteLine(person);

            caretaker.RestoreState(DateTime.Now.AddSeconds(-4));
            Console.WriteLine(person);

            caretaker.RestoreState(DateTime.Now.AddSeconds(-1));
            Console.WriteLine(person);

            person = null;
            caretaker.Dispose();
        }
    }
}
