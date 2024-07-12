namespace Lesson13;
using System.Text;

class Bai08
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 8: hiển thị 1 dòng chữ lượt chơi của người "Player 1" hoặc "Player 2"
        // trước khi người chơi nhập x và y

        InitCaroTable();

        do
        {
            if (player1)
            {
                Console.WriteLine("Player 1");
            }
            else Console.WriteLine("Player 2");
            Console.Write($"Nhập vào x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Nhập vào y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (player1)
            {
                caroTable[x, y] = "X";
                player1 = !player1;
            }
            else
            {
                caroTable[x, y] = "O";
                player1 = !player1;
            }
            DrawCaroTable();
        }
        while (true);

    }

    static bool player1 = true;
    static int n = 5;
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