namespace DesignPatterns.Behavioral.State
{
    internal class CoffeeMachine
    {
        private State _state;

        public State State
        {
            get => _state;
            set
            {
                _state = value;
                System.Console.WriteLine($"State changed to: {_state.GetType().Name}");
            }
        }

        public void PowerOn()
        {
            State = new HeatingUpState(this);
        }

        public void SmallCoffee()
        {
            _state.Small();
        }

        public void LargeCoffee()
        {
            _state.Large();
        }
    }
}
