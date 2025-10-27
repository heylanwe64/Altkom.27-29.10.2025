namespace SOLID
{
    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public override double Area => Side * Side;
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }

        public override double Area => Width * Height;
        
        public double Height { get; set; }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area => Math.PI * Radius * Radius;
    }

    public class ShapeCalculator
    {

        public double CalculateArea(Shape shape)
        {
            return shape.Area;
        }


        /* public double CalculateArea(Shape shape)
         {
             switch (shape)
             {
                 case Square square:
                     return square.Side * square.Side;
                 case Rectangle rectangle:
                     return rectangle.Width * rectangle.Height;
                 case Circle circle:
                     return Math.PI * circle.Radius * circle.Radius;
                 default:
                     throw new ArgumentException("Invalid shape");
             }
         }*/
    }
}
