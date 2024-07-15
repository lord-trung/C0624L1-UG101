namespace Lesson13;
using System.Text;

class GameCaro
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Tạo hàm xét điều kiện chiến thắng của game
        // Hoàn thành game

        InitCaroTable();
        DrawCaroTable();
        PlayGame();
    }

    static bool player1 = true;
    static int numberOfRowCol = 15;
    static int numberToWin = 3;
    static bool playing = true;
    static string[,] caroTable = new string[numberOfRowCol, numberOfRowCol];
    static void InitCaroTable()
    {

        for (int row = 0; row < numberOfRowCol; row++)
        {
            for (int col = 0; col < numberOfRowCol; col++)
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
        for (int row = 0; row < caroTable.GetLength(0); row++)
        {
            for (int col = 0; col < caroTable.GetLength(1); col++)
            {
                if (col == 0 || row == 0)
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
        while (playing)
        {
            if (player1)
            {
                Console.WriteLine("Player X's turn");
            }
            else Console.WriteLine("Player O's turn");

            repeatInput:
            Console.Write($"Nhập vào row: ");
            int row;
            int.TryParse(Console.ReadLine(), out row);
            Console.Write($"Nhập vào col: ");
            int col;
            int.TryParse(Console.ReadLine(), out col);

            if (row <= 0 || row >= numberOfRowCol || col <= 0 || col >= numberOfRowCol || caroTable[row, col] != "-")
            {
                Console.WriteLine("Invalid Position");
                goto repeatInput;
            }

            if (player1)
            {
                caroTable[row, col] = "X";
            }
            else
            {
                caroTable[row, col] = "O";
            }

            DrawCaroTable();
            checkWinCondition(row, col, player1 ? "X" : "O");
            player1 = !player1;
        }
    }

    // Kiểm tra điều kiện thắng
    static void checkWinCondition(int row, int col, string player)
    {
        int count = 0;
        int startRow;
        int startCol;
        int currentRow;
        int currentCol;

        // check horizontal
        for (int i = 1; i < numberOfRowCol; i++)
        {
            if (caroTable[row, i] == player)
            {
                count++;
                if (count >= numberToWin)
                {
                    Console.Write($"{player} win!!");
                    playing = false;
                    return;
                }
            }
            else
            {
                count = 0;
            }

        }

        // check vertical
        for (int i = 1; i < numberOfRowCol; i++)
        {
            if (caroTable[i, col] == player)
            {
                count++;
                if (count >= numberToWin)
                {
                    Console.Write($"{player} win!!");
                    playing = false;
                    return;
                }
            }
            else
            {
                count = 0;
            }
        }

        // check diagonal #1 (theo chiều từ trái sang phải, từ trên xuống dưới)
        if (row > col)
        {
            startRow = (row - col) + 1;
            startCol = 1;
            currentRow = startRow;
            currentCol = startCol;

            while (currentRow < numberOfRowCol)
            {
                if (caroTable[currentRow, currentCol] == player)
                {
                    count++;
                    currentRow++;
                    currentCol++;
                    if (count >= numberToWin)
                    {
                        Console.Write($"{player} win!!");
                        playing = false;
                        return;
                    }
                }
                else
                {
                    count = 0;
                    currentRow++;
                    currentCol++;
                }
            }
        }
        else
        {
            startRow = 1;
            startCol = (col - row) + 1;
            currentRow = startRow;
            currentCol = startCol;

            while (currentCol < numberOfRowCol)
            {
                if (caroTable[currentRow, currentCol] == player)
                {
                    count++;
                    currentRow++;
                    currentCol++;
                    if (count >= numberToWin)
                    {
                        Console.Write($"{player} win!!");
                        playing = false;
                        return;
                    }
                }
                else
                {
                    count = 0;
                    currentRow++;
                    currentCol++;
                }
            }
        }

        // check diagonal #2 (theo chiều từ trái sang phải, từ dưới lên trên)
        if (row > col)
        {
            for (int r = row, c = col; c >= 1; r++, c--)
            {
                startRow = r;
                startCol = c;

            }
            currentRow = startRow;
            currentCol = startCol;

            while (currentRow >= 1)
            {
                if (caroTable[currentRow, currentCol] == player)
                {
                    count++;
                    currentRow--;
                    currentCol++;
                    if (count >= numberToWin)
                    {
                        Console.Write($"{player} win!!");
                        playing = false;
                        return;
                    }
                }
                else
                {
                    count = 0;
                    currentRow--;
                    currentCol++;
                }
            }
        }
        else
        {
            for (int r = row, c = col; c >= 1; r++, c--)
            {
                startRow = r;
                startCol = c;

            }
            currentRow = startRow;
            currentCol = startCol;

            while (currentRow >= 1)
            {
                if (caroTable[currentRow, currentCol] == player)
                {
                    count++;
                    currentRow--;
                    currentCol++;
                    if (count >= numberToWin)
                    {
                        Console.Write($"{player} win!!");
                        playing = false;
                        return;
                    }
                }
                else
                {
                    count = 0;
                    currentRow--;
                    currentCol++;
                }
            }
        }
    }
}