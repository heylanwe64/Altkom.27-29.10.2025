namespace SOLID.L
{
    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    public class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public override double Area => Width * Height;
    }

    //złamanie LSP
    public class Square : Rectangle
    {
        public override double Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Height
        {
            get => base.Height;
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

    }
}
