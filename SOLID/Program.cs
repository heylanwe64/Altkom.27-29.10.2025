

using SOLID.L;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());



var rectangle = CreateRectangle(a, b);

Console.WriteLine($"Pole prostokąta o bokach {a} i {b} wynosi: {rectangle.Area}");

Rectangle CreateRectangle(int a, int b)
{
    return new Square { Width = a, Height = b };
}