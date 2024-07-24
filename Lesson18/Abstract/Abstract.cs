namespace Abstract;

class Abstract
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(10, "Cirle");
        Console.WriteLine(circle.GetPerimeter());
    }
}