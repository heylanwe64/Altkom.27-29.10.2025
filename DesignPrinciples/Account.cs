namespace DesignPrinciples
{
    public class Account
    {
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }

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
