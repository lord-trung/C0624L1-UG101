namespace Lesson09;
using System.Text;

class Bai02
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 2: tạo một mảng số nguyên có 10 phần từ (các giá trị các bạn tự nhập)
        // hiển thị mảng này ra màn hình
        // mỗi giá trị cách nhau 1 ký tự trắng

        int[] numberList = new int[10];

        for (int i = 0; i < numberList.Length; i++)
        {
            Console.Write($"Nhập vào giá trị thứ {i}: ");
            numberList[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Các giá trị trong mảng là: ");
        for (int i = 0; i < numberList.Length; i++)
        {
            Console.Write($"{numberList[i]} ");
        }
    }
}