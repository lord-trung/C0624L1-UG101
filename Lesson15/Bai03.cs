namespace Lesson15;
using System.Text;

class Bai03
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        
        // Câu 3: thiết kế lớp Student => tự suy nghĩ để liệt kê các properties
        // và tạo 2 đến 3 constructor
        // tạo method GetInfo để  hiển thị thông tin của mỗi Student
        // tạo 2 đối tượng sử dụng 2 constructor

        Student Trung = new Student("Vũ Thành Trung");
        Student Trung_2 = new Student("Vũ Thành Trung 2", 18, 8);
        Student Trung_3 = new Student();

        Trung.gender = true;
        Trung_2.gender = true;

        Trung.GetInfo();
        Trung_2.GetInfo();
    }
}

class Student
{
    internal string fullName;
    internal int age;
    internal bool gender;
    internal float grade;

    internal Student() { }
    internal Student(string _fullName)
    {
        this.fullName = _fullName;
    }
    internal Student(string _fullName, int _age)
    {
        this.fullName = _fullName;
        this.age = _age;
    }
    internal Student(float _grade)
    {
        this.grade = _grade;
    }

    internal Student(string _fullName, int _age, float _grade)
    {
        this.fullName = _fullName;
        this.age = _age;
        this.grade = _grade;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Student: {this.fullName}. Age: {this.age}. Gender: {(this.gender ? "male" : "female")}. Grade: {this.grade}");
    }
}