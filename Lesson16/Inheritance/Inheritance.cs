namespace Inheritance;
using System.Text;

class Inheritance
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Trainer Khoa = new Trainer();
        Student Trung = new Student();

        Khoa.fullName = "Khoa";
        Trung.fullName = "Vũ Thành Trung";
        Console.Write("test");
    }
}