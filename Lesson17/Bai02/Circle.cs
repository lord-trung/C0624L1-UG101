class Circle
{
    private float radius;
    private string color;

    public Circle() { }
    public Circle(float _radius, string _color)
    {
        this.radius = _radius;
        this.color = _color;
    }

    public float GetRadius()
    {
        return radius;
    }

    public void SetRadius(float _radius)
    {
        this.radius = _radius;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string _color)
    {
        this.color = _color;
    }

    public virtual double GetArea()
    {
        return radius * radius * Math.PI;
    }

    public override string ToString()
    {
        return $"Radius = {radius}, color = {color}";
    }
}