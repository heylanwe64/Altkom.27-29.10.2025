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
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }
        public bool IsDeleted { get; set; }

        public float Balance => Income - Outcome;


        public bool TryCharge(float amount)
        {
            if (Balance + AllowedDebit < amount)
                return false;

            Outcome += amount;
            return true;
        }

        public void AddIncome(float amount)
        {
            Income += amount;
        }
    }
}