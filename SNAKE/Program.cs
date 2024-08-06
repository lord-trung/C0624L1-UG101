using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        Thread inputListener = new Thread(ListenKey);
        inputListener.Start();

        Thread Timer = new Thread(PlayTimeCount);
        Timer.Start();

        while (playing)
        {
            LoadHighScores();
            SetupGameData();
            DrawGameScreen();
            SnakeMoving();
            CreateFood();

            Task.Delay(delayTime).Wait();
        }
    }

    static bool playing = true;
    static string right = "right";
    static string left = "left";
    static string down = "down";
    static string up = "up";
    static int gameWidth = 20;
    static int gameHeight = 20;
    static string[,] gameScreen = new string[gameHeight, gameWidth];
    static Point[] snake = new Point[2]
    {
        new Point(1, 3, right),
        new Point(1, 2, right),
    };
    static bool foodExist = false;
    static int foodRow;
    static int foodCol;
    static Point food = new Point(foodRow, foodCol);
    static int delayTime = 160;
    static int speed = 1;
    static int score = 0;
    static int secondPlayTime = 0;
    static int minutesPlayTime = 0;
    static Point bittenPart = new Point(-1, -1);
    static Point tempPart;
    static int[] highScores = new int[5];
    static string path = @"";
    static string highScoreFileName = "HighScores.txt";
    static string highScoreUrl = Path.Combine(path, highScoreFileName);
    static string logFileName = "Log.txt";
    static string LogUrl = Path.Combine(path, logFileName);

    static void SetupGameData()
    {
        // Đường viền sẽ hiển thị bằng ký hiệu #, phần còn lại là khoảng trắng
        for (int row = 0; row < gameHeight; row++)
        {
            for (int col = 0; col < gameWidth; col++)
            {
                if (row == 0 || row == gameHeight - 1 || col == 0 || col == gameWidth - 1)
                {
                    gameScreen[row, col] = "#";
                }
                else
                {
                    gameScreen[row, col] = " ";
                }
            }
        }

        // Thân rắn sẽ hiển thị bằng ký hiệu +, đầu rắn sẽ là mũi tên
        for (int i = 0; i < snake.Length; i++)
        {
            gameScreen[snake[i].row, snake[i].col] = "+";
        }

        switch (snake[0].direction)
        {
            case "up":
                gameScreen[snake[0].row, snake[0].col] = "^";
                break;

            case "down":
                gameScreen[snake[0].row, snake[0].col] = "v";
                break;

            case "right":
                gameScreen[snake[0].row, snake[0].col] = ">";
                break;

            case "left":
                gameScreen[snake[0].row, snake[0].col] = "<";
                break;
        }

        // Thức ăn sẽ được hiển thị bằng ký hiệu @
        gameScreen[foodRow, foodCol] = "@";
    }

    static void DrawGameScreen()
    {
        Console.Clear();
        Console.WriteLine($"\tSpeed: {speed}\t Score: {score}\t Time: {minutesPlayTime}m {secondPlayTime}s\n");
        for (int row = 0; row < gameHeight; row++)
        {
            for (int col = 0; col < gameWidth; col++)
            {
                if (row == bittenPart.row && col == bittenPart.col)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write($"{gameScreen[row, col]} ");
            }
            Console.WriteLine();
        }
    }

    static void SnakeMoving()
    {
        // Di chuyển thân snake bằng cách di chuyển từ đuôi lên đầu (từ phần tử cuối cùng đến phần tử đầu tiên)
        // Phần tử được di chuyển sau khi di chuyển sẽ có giá trị bằng với phần tử đứng trước nó
        for (int i = snake.Length - 1; i > 0; i--)
        {
            snake[i] = new Point(snake[i - 1].row, snake[i - 1].col, snake[i - 1].direction);
        }

        // Di chuyển đầu rắn
        switch (snake[0].direction)
        {
            case "up":
                if (snake[0].row == 1)
                {
                    snake[0].row = gameHeight - 2;
                }
                else
                {
                    snake[0].row--;
                }
                break;

            case "down":
                if (snake[0].row == gameHeight - 2)
                {
                    snake[0].row = 1;
                }
                else
                {
                    snake[0].row++;
                }
                break;

            case "right":
                if (snake[0].col == gameWidth - 2)
                {
                    snake[0].col = 1;
                }
                else
                {
                    snake[0].col++;
                }
                break;

            case "left":
                if (snake[0].col == 1)
                {
                    snake[0].col = gameWidth - 2;
                }
                else
                {
                    snake[0].col--;
                }
                break;
        }

        // Kiểm tra snake vừa ăn thức ăn hay tự cắn vào đuôi
        // LƯU Ý: Hàm EatFood() phải luôn đứng trước hàm GameOver(())
        EatFood();
        GameOver();

        tempPart = snake[snake.Length - 1];
    }

    static void CreateFood()
    {
        if (!foodExist)
        {
            bool check = false;

            // Tạo vị trí mới cho food và kiểm tra xem vị trị mới có bị trùng với bất cứ phần tử nào trong mảng snake không
            // Nếu có thì lặp lại đến khi không còn trùng
            while (!check)
            {
                check = true;
                Random random = new Random();
                foodRow = random.Next(1, gameHeight - 1);
                foodCol = random.Next(1, gameWidth - 1);
                food = new Point(foodRow, foodCol);

                for (int i = 0; i < snake.Length; i++)
                    if (foodRow == snake[i].row && foodCol == snake[i].col)
                    {
                        check = false;
                    }
            }

            foodExist = true;
        }
    }

    static void EatFood()
    {
        if (snake[0].row == foodRow && snake[0].col == foodCol)
        {
            foodExist = false;

            // Tăng điểm của người chơi
            score++;

            // Tăng tốc độ của game và tốc độ hiển thị trên màn hình
            if (delayTime > 10)
            {
                delayTime -= 10;
                speed++;
            }

            // Tăng chiều dài của snake bằng cách tăng kích thước mảng snake và thêm 1 phần tử mới vào cuối mảng
            Point tempPoint = snake[snake.Length - 1];
            Array.Resize(ref snake, snake.Length + 1);
            snake[snake.Length - 1] = tempPart;

        }
    }

    static void GameOver()
    {
        for (int i = 1; i < snake.Length; i++)
        {
            if (snake[0].row == snake[i].row && snake[0].col == snake[i].col)
            {
                playing = false;
                bittenPart = snake[i];
                DrawGameScreen();
                Console.WriteLine();
                Console.WriteLine($"\tGAME OVER!!");
                SaveHighScore();
                ShowHighScores();
                Environment.Exit(0);
            }
        }
    }

    static void ListenKey()
    {
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    // if (snake[0].direction != down)
                    if (snake[1].direction != down)
                    {
                        snake[0].ChangeDirection(up);
                    }
                    break;

                case ConsoleKey.DownArrow:
                    // if (snake[0].direction != up)
                    if (snake[1].direction != up)
                    {
                        snake[0].ChangeDirection(down);
                    }
                    break;

                case ConsoleKey.RightArrow:
                    // if (snake[0].direction != left)
                    if (snake[1].direction != left)
                    {
                        snake[0].ChangeDirection(right);
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    // if (snake[0].direction != right)
                    if (snake[1].direction != right)
                    {
                        snake[0].ChangeDirection(left);
                    }
                    break;
            }
        }
    }

    static void PlayTimeCount()
    {
        while (playing)
        {
            secondPlayTime++;

            if (secondPlayTime == 60)
            {
                secondPlayTime = 0;
                minutesPlayTime++;
            }

            Task.Delay(1000).Wait();
        }
    }

    static void SaveHighScore()
    {
        bool check = false;
        for (int i = 0; i < highScores.Length; i++)
        {
            if (highScores[i] == score)
            {
                check = true;
            }
        }

        if (!check)
        {
            for (int i = 0; i < highScores.Length; i++)
            {
                if (highScores[i] < score && highScores[i] != score)
                {
                    for (int j = highScores.Length - 1; j > i; j--)
                    {
                        highScores[j] = highScores[j - 1];
                    }
                    highScores[i] = score;
                    break;
                }
            }
        }

        FileStream fs = new FileStream(highScoreUrl, FileMode.Create);
        using (StreamWriter writer = new StreamWriter(fs))
        {
            for (int i = 0; i < highScores.Length; i++)
            {
                writer.WriteLine(highScores[i]);
            }
        }
    }

    static void LoadHighScores()
    {
        try
        {
            FileStream fs = new FileStream(highScoreUrl, FileMode.Open);
            using (StreamReader reader = new StreamReader(fs))
            {
                for (int i = 0; i < highScores.Length; i++)
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        highScores[i] = Convert.ToInt32(line);
                    }
                    else
                    {
                        highScores[i] = 0;
                    }
                }
            }
        }
        catch (Exception)
        {
            SaveHighScore();
        }
    }

    static void ShowHighScores()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=====HIGH SCORES=====");
        for (int i = 0; i < highScores.Length; i++)
        {
            if (highScores[i] == score)
            {
                Console.WriteLine($"{i + 1}.\t{highScores[i]}\t<====== YOU");
            }
            else
            {
                Console.WriteLine($"{i + 1}.\t{highScores[i]}");
            }
        }
        Console.WriteLine("=====================");
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