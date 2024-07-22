namespace OOPPractice;

class Bird : Pet
{
    public string featherColor;
    public string wingSpan;
    public string beakType;

    public Bird() { }
    public Bird(string _eyeColor, float _weight, string _featherColor) : base(_eyeColor, _weight)
    {
        this.featherColor = _featherColor;
    }
    public void Squawk() { }
    public void Fly() { }

    public override string Speak()
    {
        return base.Speak() + "Quak quak";
    }
}