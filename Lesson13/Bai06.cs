namespace Lesson13;
using System.Text;

class Bai06
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 6:
        // yêu cầu người dùng nhập vào 2 giá trị x và y
        // sau đó gán caro_table[x, y] = "X"
        // và gọi hàm DrawTable
        // việc này sẽ được lặp mãi mãi (edited) 

        InitCaroTable();
        Console.Write($"Nhập vào x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Nhập vào y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        caroTable[x, y] = "X";
        DrawCaroTable();
    }

    static int n = 15;
    static string[,] caroTable = new string[n, n];
    static void InitCaroTable()
    {

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == 0)
                {
                    caroTable[row, col] = row.ToString();
                }
                else
                {
                    if (row == 0)
                    {
                        caroTable[row, col] = col.ToString();
                    }
                    else
                    {
                        caroTable[row, col] = "-";
                    }
                }
            }
        }
    }

    static void DrawCaroTable()
    {
        for (int row = 0; row < caroTable.GetLength(0); row++)
        {
            for (int col = 0; col < caroTable.GetLength(1); col++)
            {
                Console.Write($"{caroTable[col, row]}\t");
            }
            Console.WriteLine();
        }
    }
}