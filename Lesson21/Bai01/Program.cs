using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        string path = @"E:\Learning\C0624L1-UG101\Lesson21\Bai01";
        string fileName = "profile2.txt"; // Lỗi sai. Sửa: "profile2.txt" --> "profile.txt"
        string url = Path.Combine(path, fileName);

        string logFileName = "Log.txt";
        string logUrl = Path.Combine(path, logFileName);

        try
        {
            FileStream fs = new FileStream(url, FileMode.Open);

            using (StreamReader reader = new StreamReader(fs))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch (System.Exception ex)
        {
            FileStream fs = new FileStream(logUrl, FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine($"[ERROR] {DateTime.UtcNow.Date.ToShortDateString()} - {ex.Message}");
            }
        }
    }
}