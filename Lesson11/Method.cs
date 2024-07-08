namespace Lesson11;
using System.Text;

class Method
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Khai báo hàm
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
        }

        // Chạy hàm PrintHelloWorld
        PrintHelloWorld();
    }
}