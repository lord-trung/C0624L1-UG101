using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        string fileName = "array.txt";
        string path = @"E:\Learning\C0624L1-UG101\Lesson21\Bai02";
        string url = Path.Combine(path, fileName);

        Console.Write($"Nhập vào số size: ");
        int size;
        int.TryParse(Console.ReadLine(), out size);
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Random random = new Random();
            array[i] = random.Next(10, 90);
        }

        FileStream fs = new FileStream(url, FileMode.Create);
        using (StreamWriter writer = new StreamWriter(fs))
        {
            writer.WriteLine($"{size}");
            for (int i = 0; i < array.Length; i++)
            {
                writer.Write($"{array[i]} ");
            }
        }
    }
}