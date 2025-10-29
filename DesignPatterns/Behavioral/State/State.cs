namespace DesignPatterns.Behavioral.State
{
    internal abstract class State
    {
        protected CoffeeMachine CoffeeMachine { get; }
        protected State(CoffeeMachine coffeeMachine)
        {
            CoffeeMachine = coffeeMachine;
        }

        public abstract void Small();
        public abstract void Large();
    }
}
