namespace Lesson11;
using System.Text;

class Bai04
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // câu 4:  Hãy viết 1 phương đặt tên là CreateArray, nhiệm tạo ra 1 mảng có n phần từ,
        // các giá trị được sinh ngẫu nhiên trong khoảng từ 10, 90
        // hiển thị mảng ra màn hình nếu muốn

        static int[] CreateArray(int _n, int Min, int Max)
        {
            {
                int[] arr = new int[_n];
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(Min, Max);
                }
                return arr;
            }

        }

        void PrintArray(int[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
        }

        PrintArray(CreateArray(5, 1, 200));
    }
}