namespace OOPPractice;
class Bai02
{
    static void Main(string[ ]args)
    {
        Circle circle1 = new Circle(10, "red");
        Console.WriteLine(circle1.GetArea());
        Console.WriteLine(circle1.ToString());

        Cylinder cylinder1 = new Cylinder(10, "blue", 5);
        Console.WriteLine(cylinder1.GetArea());
        Console.WriteLine(cylinder1.ToString());
    }
}

