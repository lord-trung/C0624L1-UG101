namespace Lesson13;
using System.Text;

class Bai11
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu số 11: kiểm tra tính hợp của người chơi
        // khi người chơi nhập x và y
        // x và y chỉ hợp lệ khi
        // + x và y > 0
        // + x và y < 15
        // + caro_table[x, y] phải đang là dấu "-"
        // nếu người dùng nhập vào x và y không hợp lệ
        // thì hiển thị thông báo "Invalid Position"
        // và yêu cầu người chơi đó nhập lại, cho đến khi x và y hợp thì mới được chuyển sang người khác

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

            if (player1)
            {
                Console.WriteLine("Player 1");
            }
            else Console.WriteLine("Player 2");

            repeatInput:
            Console.Write($"Nhập vào x: ");
            int x;
            int.TryParse(Console.ReadLine(), out x);
            Console.Write($"Nhập vào y: ");
            int y;
            int.TryParse(Console.ReadLine(), out y);

            if (x <= 0 || x >= n || y <= 0 || y >= 15 || caroTable[x, y] != "-")
            {
                Console.WriteLine("Invalid Position");
                goto repeatInput;
            }

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
}