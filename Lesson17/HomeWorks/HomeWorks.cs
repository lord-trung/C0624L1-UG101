namespace HomeWorks;

class HomeWorks
{
    static void Main(string[] args)
    {
        Circle circle_1 = new Circle();
        Circle circle_2 = new Circle(10);
        Circle circle_3 = new Circle("red", false, 10);

        Rectangle rectangle_1 = new Rectangle();
        Rectangle rectangle_2 = new Rectangle(15, 10);
        Rectangle rectangle_3 = new Rectangle("red", false, 15, 10);

        Square square_1 = new Square();
        Square square_2 = new Square(20);
        Square square_3 = new Square("red", false, 20);

        Console.WriteLine($"circle_1: {circle_1.ToString()}");
        Console.WriteLine($"circle_2: {circle_2.ToString()}");
        Console.WriteLine($"circle_3: {circle_3.ToString()}");
        Console.WriteLine();
        Console.WriteLine($"rectangle_1: {rectangle_1.ToString()}");
        Console.WriteLine($"rectangle_2: {rectangle_2.ToString()}");
        Console.WriteLine($"rectangle_3: {rectangle_3.ToString()}");
        Console.WriteLine();
        Console.WriteLine($"square_1: {square_1.ToString()}");
        Console.WriteLine($"square_2: {square_2.ToString()}");
        Console.WriteLine($"square_3: {square_3.ToString()}");
    }
}