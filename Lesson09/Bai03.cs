namespace Lesson09;
using System.Text;

class Bai03
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 3: hãy tạo 1 mảng có 10 phần tử (mảng điểm hệ số 10),
        // sau đó yêu cầu người dùng nhập vào 10 giá trị,
        // hiển thị toàn bộ điển ra màn hình, mỗi điểm cách nhau bằng dấu chấm phẩy,
        // hiển thị điểm lớn nhất
        // và hiển thị điểm nhỏ nhất

        double[] bangDiem = new double[10];

        int count = 0;
        while (count < bangDiem.Length)
        {
            Console.Write($"Nhập vào điểm thứ {count}: ");

            double diem = 0;
            double.TryParse(Console.ReadLine(), out diem);

            if (diem < 0 || diem > 10)
            {
                Console.Write($"Nhập vào điểm thứ {count + 1}: ");
                double.TryParse(Console.ReadLine(), out diem);
            }
            else
            {
                bangDiem[count] = diem;
                count++;
            }
        }


        Console.Write("Các điểm trong mảng: ");
        for (int i = 0; i < bangDiem.Length; i++)
        {
            Console.Write($"{bangDiem[i]} ");
        }
        Console.WriteLine($"Điểm lớn nhất là : {bangDiem.Max()}");
        Console.WriteLine($"Điểm nhỏ nhất là : {bangDiem.Min()}");

    }
}