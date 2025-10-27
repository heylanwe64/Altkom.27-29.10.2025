namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Elevator
    {
        public void Execute(IElevatorOperation operation, int floor)
        {
            operation.Operate(floor);
        }

        public void Execute(string operation, int floor)
        {
            IElevatorOperation? elevatorOperation = CreateOperation(operation);

            if (elevatorOperation is not null)
                elevatorOperation.Operate(floor);
        }

        private Dictionary<string, IElevatorOperation> _operations = [];
        //metoda wytwórcza nie musi zawsze tworzyć nowych obiektów
        //możemy zastosować cache'owanie
        protected virtual IElevatorOperation? CreateOperation(string operation)
        {
            if (_operations.TryGetValue(operation, out var result))
            {
                return result;
            }

            result = operation.ToUpper() switch
            {
                "UP" => new ElevatorUp(),
                "DOWN" => new ElevatorDown(),
                "GOTO" => new ElevatorGoTo(),
                _ => null
            };

            if (result is not null)
            {
                _operations[operation] = result;
            }

            return result;
        }
    }
}
