namespace Abstract;

class Square : Geometry
{
    double side;

    public Square()
    {
        side = 0;
    }
    public Square(double _side)
    {
        side = _side;
    }
    public Square(double _side, string _type) : base(_type)
    {
        side = _side;
    }

    public override double GetPerimeter()
    {
        return side * 4;
    }
    public override double GetArea()
    {
        return side * side;
    }
}