namespace DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Customer? customer, float amount)
        {
            if (customer == null)
                return false;

            return customer.Account.TryCharge(amount);
        }

        public void AddIncome(Customer? customer, float amount)
        {
            if (customer == null)
                return;
            customer.Account.AddIncome(amount);
        }
    }
}