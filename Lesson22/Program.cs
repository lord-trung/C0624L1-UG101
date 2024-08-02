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
            SnakeMove();
            CreateFood();

            Task.Delay(delayTime).Wait();
        }
        while (playing);
    }

    static bool playing = true;
    static string up = "up";
    static string down = "down";
    static string left = "left";
    static string right = "right";
    static int delayTime = 550;
    static int minDelayTime = 100;
    static int speed = 1;
    static int numOfRow = 40;
    static int numOfCol = 40;
    static string[,] gameScreen = new string[numOfRow, numOfCol];
    static int headRow = 1;
    static int headCol = 1;
    static Point snakeHead = new Point(headRow, headCol, right);
    static bool isFoodExist = false;
    static int foodRow;
    static int foodCol;
    static Point food = new Point(foodRow, foodCol);
    static int score = 0;
    static Point[] theSnake = new Point[1] { snakeHead };

    // Setup game
    static void SetupGame()
    {
        // Tạo đường viền và khoảng trắng
        for (int row = 0; row < numOfRow; row++)
        {
            for (int col = 0; col < numOfCol; col++)
            {
                if (row == 0 || row == numOfRow - 1 || col == 0 || col == numOfCol - 1)
                {
                    gameScreen[row, col] = "#";
                }
                else
                {
                    gameScreen[row, col] = " ";
                }
            }
        }

        // Đặt thân rắn
        for (int i = 0; i < theSnake.Length; i++)
        {
            gameScreen[theSnake[i].row, theSnake[i].col] = "+";
        }

        // Đặt đầu rắn
        gameScreen[snakeHead.row, snakeHead.col] = "O";

        // Đặt thức ăn
        gameScreen[food.row, food.col] = "@";
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
        Console.WriteLine($"Score: {score}\tSpeed: {speed}\tDirection: {snakeHead.direction}\t");
    }

    // Hàm để di chuyển rắn
    static void SnakeMove()
    {
        // Di chuyển thân rắn
        for (int i = theSnake.Length - 1; i > 0; i--)
        {
            theSnake[i] = new Point(theSnake[i - 1].row, theSnake[i - 1].col, theSnake[i - 1].direction);
        }

        // di chuyển đầu rắn
        switch (snakeHead.direction)
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

        // Kiểm tra rắn vừa ăn thức ăn hay tự cắn vào đuôi
        // Lưu ý là hàm GameOver phải luôn đứng trước hàm EatFood
        GameOver();
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
                    if (snakeHead.direction != down)
                    {
                        snakeHead.ChangeDirection(up);
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (snakeHead.direction != up)
                    {
                        snakeHead.ChangeDirection(down);
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (snakeHead.direction != left)
                    {
                        snakeHead.ChangeDirection(right);
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (snakeHead.direction != right)
                    {
                        snakeHead.ChangeDirection(left);
                    }
                    break;
            }
        }
        while (true);
    }

    // Tạo và di chuyển thức ăn vào 1 vị trí ngẫu nhiên không bị trùng với vị trí của rắn
    static void CreateFood()
    {
        if (!isFoodExist)
        {
            int row, col;
            bool check = false;

            // Kiểm tra vị trí mới của food có bị trùng với vị trí của rắn hay không
            // Lặp lại cho tới khi không trùng
            while (!check)
            {
                Random random = new Random();
                row = random.Next(1, numOfRow - 1);
                col = random.Next(1, numOfCol - 1);

                for (int i = 0; i < theSnake.Length; i++)
                {
                    if (row != snakeHead.row && col != snakeHead.col)
                    {
                        check = true;
                    }
                }

                // Gán vị trí mới đã hợp lệ cho thức ăn
                food = new Point(row, col);
                isFoodExist = true;
            }

        }
    }

    // Ăn thức ăn
    static void EatFood()
    {
        if (snakeHead.row == food.row && snakeHead.col == food.col)
        {
            // Dòng lệnh này sẽ khiến hàm CreateFood di chuyển thức ăn đến 1 vị trí khác
            isFoodExist = false;

            // Tăng điểm và 
            score++;

            // Tăng tốc độ của game và tốc độ hiển thị trên màn hình, tốc độ tối đa = 10, tương đương delayTime = 100
            if (delayTime > minDelayTime)
            {
                delayTime -= 50;
                speed++;
            }

            // Tăng kích thước của mảng theSnake và thêm 1 phần từ mới vào cuối mảng
            Point tempPoint = theSnake[theSnake.Length - 1];
            Array.Resize(ref theSnake, theSnake.Length + 1);
            theSnake[theSnake.Length - 1] = tempPoint;
        }
    }

    // Kiểm tra điều kiện dừng game
    static void GameOver()
    {
        for (int i = 1; i < theSnake.Length; i++)
        {
            if (snakeHead.row == theSnake[i].row && snakeHead.col == theSnake[i].col)
            {
                playing = false;
                Console.WriteLine("GAME OVER!!");
            }
        }
    }

    class Point
    {
        public int row { get; set; }
        public int col { get; set; }
        public string direction { get; set; }

        public Point(int _row, int _col)
        {
            this.row = _row;
            this.col = _col;
        }
        public Point(int _row, int _col, string _direction)
        {
            this.row = _row;
            this.col = _col;
            this.direction = _direction;
        }

        public void ChangeDirection(string _direction)
        {
            this.direction = _direction;
        }
    }
}