namespace Lesson10;
using System.Text;

class Bai01
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // câu 1: sử dụng kỹ thuật mảng trong mảng, hãy tạo ra một mảng có 3 phần tử,
        // Mỗi phần tử của mảng chưa 1 mảng khác có lần lượt là 3, 4 và 5 phần tử
        // Hiển thị mảng này lên màn hình
        // Hiển thị tổng các phần tử trong mảng trên

        int[][] mang = new int[3][]
        {
            new int[3] { 0, 1, 2 },
            new int[4] { 3, 4, 5, 6 },
            new int[5] { 8, 9, 10, 11, 12 },
        };

        int sum = 0;

        Console.Write("Các phần tử trong mảng: ");
        for (int i = 0; i < mang.Length; i++)
        {
            for (int j = 0; j < mang[i].Length; j++)
            {
                Console.Write($"{mang[i][j]} ");
                sum += mang[i][j];
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Tổng các phần tử trong mảng: {sum}");

    }
}