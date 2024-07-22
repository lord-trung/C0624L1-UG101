using System.Drawing;

namespace HomeWorks;

class Circle : Shape
{
    private double radius;

    public Circle()
    {
        radius = 1;
    }
    public Circle(string _color, bool _filled) : base(_color, _filled)
    {
        radius = 1;
    }
    public Circle(string _color, bool _filled, double _radius) : base(_color, _filled)
    {
        radius = _radius;
    }

    public double GetRadius()
    {
        return radius;
    }
    public void SetRadius(double _radius)
    {
        radius = _radius;
    }

    public double GetArea()
    {
        return Math.PI * (radius * radius);
    }

    public double GetPerimeter()
    {
        return Math.PI * (radius * 2);
    }

    public override string ToString()
    {
        return $"A Circle with radius = {radius}, which is a subclass of {base.ToString()}";
    }
}