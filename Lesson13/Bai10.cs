namespace Lesson13;
using System.Text;

class Bai10
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 10:
        // khi hiển thị bàn caro thì
        // + số sẽ hiển thị màu Yellow
        // + X sẽ hiển thị màu Red
        // + O sẽ hiển thị màu Green
        // + - sẽ hiển thị màu mặc định (edited) 

        InitCaroTable();
        DrawCaroTable();
        PlayGame();
    }

    static bool player1 = true;
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
        Console.Clear();
        for (int col = 0; col < caroTable.GetLength(0); col++)
        {
            for (int row = 0; row < caroTable.GetLength(1); row++)
            {
                if (row == 0 || col == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{caroTable[row, col]}\t");
                    Console.ResetColor();
                }
                else
                {
                    if (caroTable[row, col] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{caroTable[row, col]}\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        if (caroTable[row, col] == "O")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{caroTable[row, col]}\t");
                            Console.ResetColor();
                        }
                        else Console.Write($"{caroTable[row, col]}\t");
                    }
                }
            }
            Console.WriteLine();
        }
    }

    static void PlayGame()
    {
        do
        {
            DrawCaroTable();
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
        }
        while (true);
    }
}