namespace DesignPatterns.Structural.Facade.I
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public decimal? PESEL { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
