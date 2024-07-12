namespace Lesson13;
using System.Text;

class Bai01
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 1: Viết hàm đặt tên là InitCaroTable để tạo 1 mảng 2 chiều đặt tên là caro-table có kích cỡ là n x n (với n = 15)
        InitCaroTable(15);
    }

    static void InitCaroTable(int n)
    {
        string[,] caroTable = new string[n, n];
    }
}