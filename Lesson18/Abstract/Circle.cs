namespace Abstract;

class Circle : Geometry
{
    double radius;

    public Circle()
    {
        this.radius = 0;
    }
    public Circle(double _radius)
    {
        this.radius = _radius;
    }
    public Circle(double _radius, string _type) : base(_type)
    {
        this.radius = _radius;
    }

    public override double GetPerimeter()
    {
        return (this.radius * 2) * Math.PI;
    }
    public override double GetArea()
    {
        return this.radius * this.radius * Math.PI;
    }
}