using System.Drawing;

namespace HomeWorks;

class Circle : Shape
{
    private double radius;

    public Circle()
    {
        this.radius = 1;
    }
    public Circle (double _radius)
    {
        this.radius = _radius;
    }
    public Circle(string _color, bool _filled) : base(_color, _filled)
    {
        this.radius = 1;
    }
    public Circle(string _color, bool _filled, double _radius) : base(_color, _filled)
    {
        this.radius = _radius;
    }

    public double GetRadius()
    {
        return this.radius;
    }
    public void SetRadius(double _radius)
    {
        this.radius = _radius;
    }

    public double GetArea()
    {
        return Math.PI * (this.radius * this.radius);
    }

    public double GetPerimeter()
    {
        return Math.PI * (this.radius * 2);
    }

    public override string ToString()
    {
        return $"A Circle with radius = {this.radius}, which is a subclass of {base.ToString()}";
    }
}