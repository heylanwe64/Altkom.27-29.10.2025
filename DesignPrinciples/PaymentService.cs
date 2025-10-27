namespace DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        public bool Charge(int customerId, float amount)
        {
            Customer? customer = FindById(customerId);
            if (customer == null)
                return false;

            return customer.TryCharge(amount);
        }


        private Customer? FindById(int customerId)
        {
            return Customers.Where(x => !x.IsDeleted).SingleOrDefault(x => x.Id == customerId);
        }

        public void AddIncome(int customerId, float amount)
        {
            var customer = FindById(customerId);
            if (customer == null)
                return;
            customer.AddIncome(amount);
        }
    }
}