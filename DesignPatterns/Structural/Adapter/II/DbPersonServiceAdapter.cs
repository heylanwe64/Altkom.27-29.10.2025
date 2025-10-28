namespace DesignPatterns.Structural.Adapter.II
{
    internal class DbPersonServiceAdapter : IPeopleService
    {
        private readonly DbPeopleService _dbPeopleService;
        public DbPersonServiceAdapter(DbPeopleService dbPeopleService)
        {
            _dbPeopleService = dbPeopleService;
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = _dbPeopleService.Read();

            return people.Select(dbPerson => new Person
            {
                FullName = $"{dbPerson.FirstName} {dbPerson.LastName}",
                Age = DateTime.Now.Year - dbPerson.DateOfBirth.Year
            }).ToList();
        }
    }
}
