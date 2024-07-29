internal class Program
{
    public static string path = @"E:\Learning\C0624L1-UG101\Lesson20\Data";
    public static string fileName = "account.txt";
    public static string url = Path.Combine(path, fileName);

    public static string fileLog = "Log.txt";

    static void Main(string[] args)
    {
        FileStream fileStream = new FileStream(url, FileMode.Append);

        // using(StreamWriter writer = new StreamWriter(fileStream))
        // {
        //     writer.WriteLine("khoa,nguyen@codegym.vn");
        // }

        // try
        // {
        //     int number = 10;
        //     int divisor = 0;
        //     Console.WriteLine(number / divisor);
        //     Console.WriteLine(number / divisor);
        // }
        // catch (System.Exception ex)
        // {
        //     FileStream fs = new FileStream(Path.Combine(path, fileLog), FileMode.Append);
        //     using (StreamWriter write = new StreamWriter(fs))
        //     {
        //         write.WriteLine($"[ERROR]: {DateTime.UtcNow.Date.ToShortDateString()} - {ex.Message}");
        //     }
        // }

        ShowLog();
    }

    public static void ShowLog()
    {
        FileStream fs = new FileStream(Path.Combine(path, fileLog), FileMode.Open);
        using (StreamReader reader = new StreamReader(fs))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}