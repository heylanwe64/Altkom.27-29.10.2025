namespace DesignPatterns.Structural.Adapter.I
{
    internal class Client
    {
        public static void Execute()
        {
            IBall ball = new Ball { R = 5 };
            CheckBall(ball);

            Cube cube = new Cube { A = 10 };
            ball = new CubeToBallAdapter(cube);
            CheckBall(ball);
        }

        public static void CheckBall(IBall ball)
        {
            Console.WriteLine(ball.R <= 5);
        }
    }
}
