namespace DesignPatterns.Behavioral.State
{
    internal class WorkingState : State
    {
        private readonly CancellationTokenSource _cancellationTokenSource;
        public WorkingState(CoffeeMachine coffeeMachine, int time) : base(coffeeMachine)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Delay(TimeSpan.FromMilliseconds(time), _cancellationTokenSource.Token)
                .ContinueWith(x =>
                {
                    CoffeeMachine.State = new IdleState(CoffeeMachine);
                    _cancellationTokenSource.Dispose();
                });
        }

        public override void Large()
        {
            Console.WriteLine("Cancelation...");
            _cancellationTokenSource.Cancel();
        }

        public override void Small()
        {
            Console.WriteLine("Cancelation...");
            _cancellationTokenSource.Cancel();
        }
    }
}