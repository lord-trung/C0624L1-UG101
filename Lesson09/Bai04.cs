namespace Lesson09;
using System.Text;

class Bai04
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 4: viết chương trình tạo một với các giá trị được người dùng nhập vào từ bàn phím
        // và chỉ kết thúc việc nhập khi người nhấn phím số 0.
        // In ra các giá trị trong mảng.

        int[] numberList = new int[0];
        int index = 0;

        while (true)
        {
            Console.Write($"Nhập vào số [{index}]: ");

            int input;
            int.TryParse(Console.ReadLine(), out input);

            if (input == 0)
            {
                break;
            }
            else
            {
                Array.Resize(ref numberList, numberList.Length + 1);
                numberList[index] = input;
                index++;
            }
        }

        Console.WriteLine("Các giá trị có trong mảng: ");
        Console.WriteLine(string.Join(" ", numberList));


    }
}