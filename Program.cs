//////////////////Task1///////////////////////
double num1 = double.Parse(Console.ReadLine());
double num2  = double.Parse(Console.ReadLine());
double sum = num1 + num2;

Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
Console.WriteLine();

//////////////////Task2///////////////////////
Rectangle rectangle1 = new Rectangle(5, 10);
Rectangle rectangle2 = new Rectangle(3, 6);

Console.WriteLine($"Perimeter of Rectangle1: {rectangle1.CalcPerimeter()}");
Console.WriteLine($"Area of Rectangle1: {rectangle1.CalcArea()}");
Console.WriteLine($"Perimeter of Rectangle2: {rectangle2.CalcPerimeter()}");
Console.WriteLine($"Area of Rectangle2: {rectangle2.CalcArea()}");
Console.WriteLine();

//////////////////Task3///////////////////////
Shape rec = new Rectanglee(5, 10);
Shape cir = new Circle(5);

Console.WriteLine("Area of Rectangle: " + rec.CalculateArea());
Console.WriteLine("Area of Circle: " + cir.CalculateArea());


class Rectangle
{
    public double Length { get; set;}
    public double Width { get; set;}
    public Rectangle(double Length, double Width)
    {
        this.Length = Length;
        this.Width = Width;
    }
    public double CalcArea()
    { return Length * Width; }
    public double CalcPerimeter() 
    { return 2 * (Length + Width); }

}

abstract class Shape
{
    public abstract double CalculateArea();
}
class Rectanglee : Shape
{
    public double Length;
    public double Width;
    public Rectanglee(double length, double width)
    {
        this.Length = length;
        this.Width = width;
    }
    public override double CalculateArea()
    {
        return Length * Width;
    }
}
class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}



