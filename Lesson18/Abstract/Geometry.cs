namespace Abstract;

abstract class Geometry
{
    public string type;

    public Geometry() { }
    public Geometry(string _type)
    {
        type = _type;
    }

    public abstract double GetPerimeter();
    public abstract double GetArea();
}

