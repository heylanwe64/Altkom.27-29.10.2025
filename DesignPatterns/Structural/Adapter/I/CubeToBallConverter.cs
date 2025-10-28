namespace DesignPatterns.Structural.Adapter.I
{
    internal static class CubeToBallConverter
    {
        public static IBall ToBall(this Cube cube)
        {
            return new Ball { R = cube.A * Math.Sqrt(3) / 2 };
        }
    }
}
