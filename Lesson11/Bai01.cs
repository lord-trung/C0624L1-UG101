namespace Lesson11;
using System.Text;

class Bai01
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Bài 1: viết phương thức, có nhiệm vụ hiển thị 10 số nguyên đầu tiên (từ 1 - 10) (edited) 

        void HienThi10SoNguyenDauTien()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
        }

        HienThi10SoNguyenDauTien();
    }
}