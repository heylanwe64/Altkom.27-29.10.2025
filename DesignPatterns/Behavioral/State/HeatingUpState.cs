namespace DesignPatterns.Behavioral.State
{
    internal class HeatingUpState : State
    {
        public HeatingUpState(CoffeeMachine coffeeMachine) : base(coffeeMachine)
        {
            Task.Delay(5000).ContinueWith(x => CoffeeMachine.State = new IdleState(CoffeeMachine));
        }

        public override void Large()
        {
            Console.WriteLine("Not now.. I am heating up");
        }

        public override void Small()
        {
            Large();
        }
    }
}