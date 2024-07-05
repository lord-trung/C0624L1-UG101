namespace Lesson10;
using System.Text;

class Bai04
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 4: sử dụng kỹ thuật mảng 2 chiều, tạo ra 1 mảng số có kích cỡ 7x7
        // Giá trị của mảng này được sinh ngẫu nhiên trong khoảng [100, 900]
        // Nếu giá trị trong khoản [100, 300] thì hiển thị màu đỏ
        // Nếu giá trị trong khoản [500, 900] thì hiển thị màu xanh
        // Còn lại thì hiển thị bình thường

        int [,] mang = new int[7,7];

        Random random = new Random();

        Console.WriteLine("Các phần tử trong mảng:");
        for (int row = 0; row < mang.GetLength(0); row++)
        {
            for (int col = 0; col < mang.GetLength(1); col++)
            {
                mang[row, col] = random.Next(100, 900);
                if (mang[row, col] > 500)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{mang[row,col]}\t");
                    Console.ResetColor();

                }
                else if (mang[row, col] <= 300) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{mang[row,col]}\t");
                    Console.ResetColor();
                }
                else Console.Write($"{mang[row,col]}\t");
            }
            Console.WriteLine();
        }

    }
}