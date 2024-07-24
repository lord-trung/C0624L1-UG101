namespace Abstract;

class Rectangle : Geometry
{
    double width;
    double length;

    public Rectangle()
    {
        this.width = 0;
        this.length = 0;
    }
    public Rectangle(double _width, double _length)
    {
        this.width = _width;
        this.length = _length;
    }
    public Rectangle(double _width, double _length, string _type) : base(_type)
    {
        this.width = _width;
        this.length = _length;
    }

    public override double GetPerimeter()
    {
        return (this.width + this.length) * 2;
    }
    public override double GetArea()
    {
        return this.width * this.length;
    }
}