using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        int row, col;
        string path = @"E:\Learning\C0624L1-UG101\Lesson21\Bai04";
        string fileName = "input.txt";
        string url = Path.Combine(path, fileName);
        Random random = new Random();

    checkRow:
        Console.Write("Nhập vào row: ");
        row = Convert.ToInt32(Console.ReadLine());
        if (row < 0 || row > 10)
        {
            Console.WriteLine("row phải lớn hơn 0 và nhỏ hơn 10");
            goto checkRow;
        }
    checkCol:
        Console.Write("Nhập vào col: ");
        col = Convert.ToInt32(Console.ReadLine());
        if (col < 0 || col > 20)
        {
            Console.WriteLine("col phải lớn hơn 0 và nhỏ hơn 20");
            goto checkCol;
        }

        int[,] numberList = new int[row, col];

        FileStream fs = new FileStream(url, FileMode.Create);
        using (StreamWriter writer = new StreamWriter(fs))
        {
            writer.WriteLine($"{row} {col}");
            for (int _row = 0; _row < row; _row++)
            {
                for (int _col = 0; _col < col; _col++)
                {
                    numberList[_row, _col] = random.Next(100, 900);
                    writer.Write($"{numberList[_row, _col]} ");
                }
                writer.WriteLine();
            }
        }
    }
}