namespace Interface;

class Square : IGeometric
{
    public double GetArea()
    {
        return -1;
    }
    public double GetPerimeter()
    {
        return -1;
    }
    public void Info()
    {
        Console.Write("Square");
    }
}