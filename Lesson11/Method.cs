namespace Lesson11;
using System.Text;

class Method
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        #region Khai báo hàm
        // static void PrintHelloWorld()
        // {
        //     Console.WriteLine("Hello World");
        //     Console.WriteLine("Hello World");
        //     Console.WriteLine("Hello World");
        // }

        // // Chạy hàm PrintHelloWorld
        // PrintHelloWorld();
        #endregion

        #region Viết một phương thức nhập vào 2 số và trả về tổng 2 số đó

        static void Sum(int _number_1, int _number_2)
        {
            int _sum = _number_1 + _number_2;

            Console.WriteLine($"{_number_1} + {_number_2} = {_sum}");
        }

        #endregion

        Sum(4, 5);
    }
}