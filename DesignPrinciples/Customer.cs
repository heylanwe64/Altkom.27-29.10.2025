namespace DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public float Income { get; set; }
        public float Outcome { get; set; }
        public float AllowedDebit { get; set; }
        public bool IsDeleted { get; set; }


        public bool IsDebit()
        {
            return Balance < 0;
        }

        public float Balance => Income - Outcome;
    }
}