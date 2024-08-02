internal class Program
{
    private static void Main(string[] args)
    {
        Thread inputListening = new Thread(ListenKey);
        inputListening.Start();

        do
        {
            SetupGame();
            DrawGameScreen();
            SnakeMoving();
            CreateFood();

            Task.Delay(delayTime).Wait();
        }
        while (true);
    }


    static string up = "up";
    static string down = "down";
    static string left = "left";
    static string right = "right";
    static int delayTime = 100;
    static int numOfRow = 10;
    static int numOfCol = 10;
    static string[,] gameScreen = new string[numOfRow, numOfCol];
    static int headRow = 1;
    static int headCol = 1;
    static string headDir = right;
    static Point snakeHead = new Point(headRow, headCol, headDir);
    static bool isFoodExist = false;
    static int foodRow;
    static int foodCol;
    static Point food = new Point(foodRow, foodCol, "none");

    // Setup game
    static void SetupGame()
    {
        for (int row = 0; row < numOfRow; row++)
        {
            for (int col = 0; col < numOfCol; col++)
            {
                if (row == 0 || row == numOfRow - 1 || col == 0 || col == numOfCol - 1)
                {
                    gameScreen[row, col] = "#";
                }
                else if (row == snakeHead.row && col == snakeHead.col)
                {
                    gameScreen[row, col] = "O";
                }
                else if (row == food.row && col == food.col)
                {
                    gameScreen[row, col] = "@";
                }
                else
                {
                    gameScreen[row, col] = " ";
                }
            }
        }
    }

    // Hiển thị màn hình game
    static void DrawGameScreen()
    {
        Console.Clear();
        for (int row = 0; row < numOfRow; row++)
        {
            for (int col = 0; col < numOfCol; col++)
            {
                Console.Write($"{gameScreen[row, col]} ");
            }
            Console.WriteLine();
        }
    }

    // Di chuyển Snake
    static void SnakeMoving()
    {
        switch (snakeHead.dir)
        {
            case "up":
                if (snakeHead.row == 1)
                {
                    snakeHead.row = numOfRow - 2;
                }
                else
                {
                    snakeHead.row--;
                }
                break;

            case "down":
                if (snakeHead.row == numOfRow - 2)
                {
                    snakeHead.row = 1;
                }
                else
                {
                    snakeHead.row++;
                }
                break;

            case "right":
                if (snakeHead.col == numOfCol - 2)
                {
                    snakeHead.col = 1;
                }
                else
                {
                    snakeHead.col++;
                }
                break;

            case "left":
                if (snakeHead.col == 1)
                {
                    snakeHead.col = numOfCol - 2;
                }
                else
                {
                    snakeHead.col--;
                }
                break;
        }
        EatFood();
    }

    // Nhận thông tin nhập vào khi người dùng bấm phím mũi tên trên bàn phím
    static void ListenKey()
    {
        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (snakeHead.dir != down)
                    {
                        snakeHead.dir = up;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (snakeHead.dir != up)
                    {
                        snakeHead.dir = down;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (snakeHead.dir != left)
                    {
                        snakeHead.dir = right;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (snakeHead.dir != right)
                    {
                        snakeHead.dir = left;
                    }
                    break;
            }
        }
        while (true);
    }

    // Spawn food
    static void CreateFood()
    {
        if (!isFoodExist)
        {
            Random random = new Random();
            int _row = random.Next(1, numOfRow - 1);
            int _col = random.Next(1, numOfCol - 1);

            if (food.row != snakeHead.row && food.col != snakeHead.col)
            {
                food = new Point(_row, _col, "none");
                isFoodExist = true;
            }
        }
    }

    // Eat food
    static void EatFood()
    {
        if (snakeHead.row == food.row && snakeHead.col == food.col)
        {
            isFoodExist = false;
        }
    }

    class Point
    {
        public int row { get; set; }
        public int col { get; set; }
        public string dir;

        public Point(int _row, int _col, string _dir)
        {
            this.row = _row;
            this.col = _col;
            this.dir = _dir;
        }
    }
}