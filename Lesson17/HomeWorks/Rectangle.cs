namespace HomeWorks;

class Rectangle : Shape
{
    private double width;
    private double length;

    public Rectangle()
    {
        this.width = 1;
        this.length = 1;
    }
    public Rectangle(double _width, double _length)
    {
        this.length = _length;
        this.width = _width;
    }
    public Rectangle(string _color, bool _isFilled) : base(_color, _isFilled)
    {
        this.width = 1;
        this.length = 1;
    }
    public Rectangle(string _color, bool _isFilled, double _width, double _length) : base(_color, _isFilled)
    {
        this.width = _width;
        this.length = _length;
    }

    public double GetWidth()
    {
        return this.width;
    }
    public virtual void SetWidth(double _width)
    {
        this.width = _width;
    }

    public double GetLength()
    {
        return this.length;
    }
    public virtual void SetLength(double _length)
    {
        this.length = _length;
    }

    public double GetArea()
    {
        return this.length * width;
    }
    public double GetPerimeter()
    {
        return (this.length + this.width) * 2;
    }

    public override string ToString()
    {
        return $"A Rectangle with width = {this.width} and length = {this.length}, which is a subclass of {base.ToString()}";
    }
}