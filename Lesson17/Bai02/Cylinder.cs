class Cylinder : Circle
{
    private float height;

    public Cylinder() { }
    public Cylinder(float _radius, string _color, float _height) : base(_radius, _color)
    {
        this.height = _height;
    }

    public void SetHeight(float _height)
    {
        this.height = _height;
    }

    public float GetHeight()
    {
        return height;
    }

    public override double GetArea()
    {
        return (2 * Math.PI * GetRadius() * height) + (2 * Math.PI * GetRadius() * GetRadius());
       
    }

    public override string ToString()
    {
        return $"{base.ToString()}, height = {height}";
    }
}