namespace Lesson10;
using System.Text;

class Bai03
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 3: sử dụng kỹ thuật mảng 2 chiều, tạo ra 1 mảng số có kích cỡ 7x7
        // Giá trị của mảng này được sinh ngẫu nhiên trong khoảng [100, 900]
        // Hiển thị mảng 2 chiều này ra màn hình
        // Chỉ hiển thị những giá trị chẳn, lẻ thì ko hiển thị

        int [,] mang = new int[7,7];

        Random random = new Random();

        Console.WriteLine("Các phần tử trong mảng:");
        for (int row = 0; row < mang.GetLength(0); row++)
        {
            for (int col = 0; col < mang.GetLength(1); col++)
            {
                mang[row, col] = random.Next(100, 900);
                Console.Write($"{mang[row,col]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Các phần tử chẵn trong mảng:");
        for (int row = 0; row < mang.GetLength(0); row++)
        {
            for (int col = 0; col < mang.GetLength(1); col++)
            {
                mang[row, col] = random.Next(100, 900);
                if (mang[row,col] % 2 == 0)
                Console.Write($"{mang[row,col]}\t");
            }
            Console.WriteLine();
        }

    }
}