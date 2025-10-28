namespace DesignPatterns.Structural.Adapter.II
{
    internal class DbPeopleService
    {
        private IEnumerable<DbPerson> _people = [

            new DbPerson { FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1990, 1, 1) },
            new DbPerson { FirstName = "Jane", LastName = "Smith", DateOfBirth = new DateTime(1985, 5, 15) },
        ];

        public IEnumerable<DbPerson> Read()
        {
            return _people.ToList();
        }
    }
}
