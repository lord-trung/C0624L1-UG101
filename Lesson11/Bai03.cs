namespace Lesson11;
using System.Text;

class Bai03
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // bài 3: viết 1 phương thức hiển thị các số nguyên từ n đến m (với điều kiện là n < m)

        void HienThiCacSoNguyenTuNDenM(int _n, int _m)
        {
            if (_n >= _m)
            {
                Console.WriteLine("Invalid numbers");
            }
            else
            for (int i = _n; i <= _m; i++)
            {
                Console.Write($"{i} ");
            }
        }

        HienThiCacSoNguyenTuNDenM(1, 10);
    }
}