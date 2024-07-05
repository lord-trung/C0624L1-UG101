namespace Lesson10;
using System.Text;

class Bai02
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // câu 2: sử dụng kỹ thuật mảng trong mảng, hay tạo ra một mảng có 4 phần tử, Mỗi phần tử chứa 1 mảng khác và đều có 4 phần tử.
        // Mảng này lưu điểm thi của sinh viên, và điểm thi thì có 1 số lẻ (ví dụ, 8.3) các giá trị của bạn các bạn gán vào khi tạo
        // Hiển thị mảng điểm này ra màn hình
        // Hiển thị điểm lớn nhất

        double[][] diemThi = new double[4][]
        {
            new double[4] { 8.2, 10, 8.3, 9 },
            new double[4] { 9.5, 5.4, 7.4, 8.2 },
            new double[4] { 3.4, 6.9, 7.9, 7.1 },
            new double[4] { 2.5, 4.5, 1.4, 3.2 },
        };

        double max = 0;

        Console.WriteLine("Danh sách điểm thi của sinh viên:");
        for (int sinhVien = 0; sinhVien < diemThi.Length; sinhVien++)
        {
            Console.Write($"Sinh viên {sinhVien + 1}:\t");
            for (int diem = 0; diem < diemThi[sinhVien].Length; diem++)
            {
                Console.Write($"{diemThi[sinhVien][diem]}\t");
                if (max < diemThi[sinhVien][diem])
                {
                    max = diemThi[sinhVien][diem];
                }
            }
            Console.WriteLine();
        }      
        Console.WriteLine($"Điểm lớn nhất là: {max}");

    }
}