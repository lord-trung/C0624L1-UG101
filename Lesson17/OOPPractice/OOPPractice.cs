namespace OOPPractice;

class OOPPractice
{
    static void Main(string[] args)
    {
        Bird newBird = new Bird("red", 12, "Blue");
        Console.Write(newBird.Speak());
    }
}