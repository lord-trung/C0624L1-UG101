namespace Lesson08;
using System.Text;

class Bai04
{
    static void Main(string[] args)
    {

        for (int num = 100; num <= 1000; num++)
        {
            bool check = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    check = false;
                    break;
                }
                                
            }
            if (check)
                {
                    Console.Write($"{num} ");
                }
        }

    }
}