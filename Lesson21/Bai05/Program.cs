using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        string inputFileName = "input.txt";
        string inputFilePath = @"E:\Learning\C0624L1-UG101\Lesson21\Bai04";
        string inputFileUrl = Path.Combine(inputFilePath, inputFileName);

        string fileName = "result_1.txt";
        string path = @"E:\Learning\C0624L1-UG101\Lesson21\Bai05";
        string url = Path.Combine(path, fileName);

        FileStream inputFS = new FileStream(inputFileUrl, FileMode.Open);
        using (StreamReader reader = new StreamReader(inputFS))
        {
            string? size = reader.ReadLine();
            string[] rowAndCol = size != null ? size.Trim().Split(" ") : new string[0];
            int row = Convert.ToInt32(rowAndCol[0]); 
            int col = Convert.ToInt32(rowAndCol[1]); 

            FileStream fs = new FileStream(url, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                for (int r = 0; r < row; r++)
                {
                    string? line = reader.ReadLine();
                    string[] elements = line != null ? line.Trim().Split(" ") : new string[0];
                    int[] array = new int[col];
                    int sum = 0;

                    for (int c = 0; c < col; c++)
                    {
                        array[c] = Convert.ToInt32(elements[c]);
                        sum += array[c];
                    }
                    writer.WriteLine($"row {r + 1}: {sum}");
                }
            }

        }
    }
}