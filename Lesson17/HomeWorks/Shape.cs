namespace HomeWorks;

class Shape
{
    private string color;
    private bool filled;

    public Shape()
    {
        color = "green";
        filled = true;
    }

    public Shape(string _color, bool _filled)
    {
        color = _color;
        filled = _filled;
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
        return filled;
    }
    public void SetFilled(bool _filled)
    {
        this.filled = _filled;
    }

    public virtual string ToString()
    {
        return $"A Shape with color of {color} and {(filled ? "filled" : "not filled")}";
    }
}