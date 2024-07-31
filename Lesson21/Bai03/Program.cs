using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        string arrayPath = @"E:\Learning\C0624L1-UG101\Lesson21\Bai02";
        string arrayFileName = "array.txt";
        string arrayUrl = Path.Combine(arrayPath, arrayFileName);

        string summaryPath = @"E:\Learning\C0624L1-UG101\Lesson21\Bai03";
        string summaryFileName = "summary.txt";
        string summaryUrl = Path.Combine(summaryPath, summaryFileName);

        int evenNumCount = 0;
        int primeNumCount = 0;

        FileStream fs = new FileStream(arrayUrl, FileMode.Open);
        using (StreamReader reader = new StreamReader(fs))
        {
            int size = Convert.ToInt32(reader.ReadLine());
            string? data = reader.ReadLine();
            string[] elements = data != null ? data.Trim().Split(" ") : new string[0];
            int[] array = new int[size];

            for (int i = 0; i < elements.Length; i++)
            {
                array[i] = Convert.ToInt32(elements[i]);
            }

            bool isPrime = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenNumCount++;
                }

                if (array[i] == 0 || array[i] == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int j = 2; j <= array[i] / 2; j++)
                    {
                        if (array[i] % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    primeNumCount++;
                }
            }

            FileStream fs2 = new FileStream(summaryUrl, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fs2))
            {
                writer.WriteLine($"Số lượng số chẵn: {evenNumCount}");
                writer.WriteLine($"Số lượng số nguyên tố: {primeNumCount}");
            }
        }
    }
}