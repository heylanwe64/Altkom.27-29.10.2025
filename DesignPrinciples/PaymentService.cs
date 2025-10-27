namespace DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Account? account, float amount)
        {
            return account?.TryCharge(amount) ?? false;
        }

        public void AddIncome(Account? account, float amount)
        {
            account?.AddIncome(amount);
        }
    }
}