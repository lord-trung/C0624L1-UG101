namespace Lesson11;
using System.Text;

class Bai02
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // bài 2: cũng là phương thức trên, có nhiệm vụ hiển thị các số nguyên từ 1 đến n (với n do người sử dụng cung cấp)

        void HienThiCacSoNguyenTu1DenNum(int _num)
        {
            for (int i = 1; i <= _num; i++)
            {
                Console.Write($"{i} ");
            }
        }

        HienThiCacSoNguyenTu1DenNum(10);
    }
}