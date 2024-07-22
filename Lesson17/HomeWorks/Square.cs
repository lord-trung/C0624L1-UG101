namespace HomeWorks;

class Square : Rectangle
{
    public Square()
    {
        SetWidth(1);
        SetLength(1);
    }

    public double GetSide()
    {
        return GetWidth();
    }
    public void SetSide(double _side)
    {
        SetWidth(_side);
        SetLength(_side);
    }

    public override void SetLength(double _side)
    {
        base.SetLength(_side);
        base.SetWidth(_side);
    }
    public override void SetWidth(double _side)
    {
        base.SetLength(_side);
        base.SetWidth(_side);
    }

    public override string ToString()
    {
        return $"A Square with side={this.GetWidth}, which is a subclass of {base.ToString()}";
    }
}