namespace Bai01;
using System.Text;

class Bai01
{
    static void Main(string[] args)
    {
        // viết chương trình yêu cầu người dùng nhập vào họ và tên, email và giới tính
        // sau đó ghi dữ liệu này vào file profile.txt mỗi thông tin trên 1 dòng
        // viết hàm đọc dữ liệu từ trong file profile.txt và hiển thị ra màn hình

        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        string path = @"E:\Learning\C0624L1-UG101\Lesson20\Bai01";
        string fileName = "profile.txt";
        string url = Path.Combine(path, fileName);

        FileStream fs = new FileStream(url, FileMode.Create);

        Console.Write($"Nhập họ và tên: ");
        string fullName = Console.ReadLine();

        Console.Write("Nhập email: ");
        string email = Console.ReadLine();

        Console.Write("Nhập giới tính: ");
        string gender = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fs))
        {
            writer.WriteLine($"Họ và tên: {fullName}");
            writer.WriteLine($"Email: {email}");
            writer.WriteLine($"Giới tính: {gender}");
        }
        
        FileStream fs2 = new FileStream(Path.Combine(path, fileName), FileMode.Open);
        using (StreamReader reader = new StreamReader(fs2))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}