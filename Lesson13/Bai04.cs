namespace Lesson13;
using System.Text;

class Bai04
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 4: Hãy gán giá trị caro_table[5,5] = "X"
        // sau đó gọi lại hàm DrawTable và quan sát kết quả

        InitCaroTable();
        caroTable[5,5] = "X";
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