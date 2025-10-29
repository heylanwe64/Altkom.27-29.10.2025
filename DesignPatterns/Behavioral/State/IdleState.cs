namespace DesignPatterns.Behavioral.State
{
    internal class IdleState : State
    {
        private readonly CancellationTokenSource _cancellationTokenSource;
        public IdleState(CoffeeMachine coffeeMachine) : base(coffeeMachine)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Delay(TimeSpan.FromMilliseconds(5000), _cancellationTokenSource.Token)
                .ContinueWith(x =>
                {
                    if(!_cancellationTokenSource.IsCancellationRequested)
                        CoffeeMachine.State = new HeatingUpState(CoffeeMachine);
                    _cancellationTokenSource.Dispose();
                });
        }

        public override void Large()
        {
            _cancellationTokenSource.Cancel();
            System.Console.WriteLine("Large coffee");
            CoffeeMachine.State = new WorkingState(CoffeeMachine, 7000);
        }

        public override void Small()
        {
            _cancellationTokenSource.Cancel();
            System.Console.WriteLine("Small coffee");
            CoffeeMachine.State = new WorkingState(CoffeeMachine, 4000);
        }
    }
}