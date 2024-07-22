namespace OOPPractice;

class Pet
{
    public string eyeColor;
    public float age;
    public float weight;
    public string location;

    public string Eat(string _foodType)
    {
        return "Eat food";
    }

    public string Sleep(int _timeLength)
    {
        return $"Pet sleep {_timeLength} hours";
    }

    public Pet() { }
    public Pet(string _eyeColor, float _weight)
    {
        this.eyeColor = _eyeColor;
        this.weight = _weight;
    }

    public virtual string Speak()
    {
        return "Speak";
    }
}