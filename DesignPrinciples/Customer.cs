namespace DesignPrinciples
{
    public class Customer : Entity
    {
        public Customer(int id)
        {
            Id = id;
        }

        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public Account Account { get; } = new Account();
    }
}