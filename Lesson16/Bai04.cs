namespace Lesson16;

class Bai04
{
    static void Main(string[] args)
    {

    }
}

class Dimension
{
    public double height;
    public double width;
    public double depth;

    public Dimension() { }
    public Dimension(double _height, double _width, double _depth)
    {
        height = _height;
        width = _width;
        depth = _depth;
    }

    public double getHeight()
    {
        return this.height;
    }
    public double getWidth()
    {
        return this.width;
    }
    public double getDepth()
    {
        return this.depth;
    }
    public string toTring(long value)
    {
        return value.ToString();
    }
}

class Phone : Dimension
{
    public string model;

    public Phone() { }
    public Phone(string _model, Dimension _dimension)
    {
        this.model = _model;
        this.height = _dimension.height;
        this.width = _dimension.width;
        this.depth = _dimension.depth;
    }
    public string call(long number)
    {
        return number.ToString();
    }
}

class SmartPhone : Phone
{
    public int store;
    public SmartPhone(string _model, Dimension _dimension, int _store)
    {
        this.model = _model;
        this.height = _dimension.height;
        this.width = _dimension.width;
        this.depth = _dimension.depth;
        this.store = _store;
    }
}