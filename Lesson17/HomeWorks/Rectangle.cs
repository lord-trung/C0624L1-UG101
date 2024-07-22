namespace HomeWorks;

class Rectangle : Shape
{
    private double width;
    private double length;

    public Rectangle()
    {
        width = 1;
        length = 1;
    }
    public Rectangle(string _color, bool _isFilled) : base(_color, _isFilled)
    {
        width = 1;
        length = 1;
    }
    public Rectangle(string _color, bool _isFilled, double _width, double _length) : base(_color, _isFilled)
    {
        width = _width;
        length = _length;
    }

    public double GetWidth()
    {
        return width;
    }
    public virtual void SetWidth(double _width)
    {
        this.width = _width;
    }

    public double GetLength()
    {
        return length;
    }
    public virtual void SetLength(double _length)
    {
        this.length = _length;
    }

    public double GetArea()
    {
        return length * width;
    }
    public double GetPerimeter()
    {
        return (length + width) * 2;
    }

    public override string ToString()
    {
        return $"A Rectangle with width = {width} and length = {length}, which is a subclass of {base.ToString()}";
    }
}