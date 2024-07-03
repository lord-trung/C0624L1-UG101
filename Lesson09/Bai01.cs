namespace Lesson09;
using System.Text;

class Bai01
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Câu 1: tạo 1 mảng có tên studentList và trong mảng này chứa tên của 5 thành viên trong lớp mình
        // sau đó, hiển thị tên và index của 5 thành đó lên màn hình

        string[] studentList = { "Vũ Thành Trung", "Đinh Tuấn Anh", "Hà Diệu Huy", "Nguyễn Dương Yến Nhi", "Lê Hữu Thịnh" };

        for (int i = 0; i < studentList.Length; i++)
        {
            Console.WriteLine(studentList[i]);
        }
    }
}