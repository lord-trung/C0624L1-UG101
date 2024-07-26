namespace HomeWorks;

class Shape
{
    private string color;
    private bool filled;

    public Shape()
    {
        this.color = "green";
        this.filled = true;
    }

    public Shape(string _color, bool _filled)
    {
        this.color = _color;
        this.filled = _filled;
    }

    public string GetColor()
    {
        return color;
    }
    public void SetColor(string _color)
    {
        this.color = _color;
    }

    public bool IsFilled()
    {
        return this.filled;
    }
    public void SetFilled(bool _filled)
    {
        this.filled = _filled;
    }

    public virtual string ToString()
    {
        return $"A Shape with color of {this.color} and {(this.filled ? "filled" : "not filled")}";
    }
}