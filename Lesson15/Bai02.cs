namespace Lesson15;

class Bai02
{
    static void Main(string[] args)
    {
        // Câu 2: tạo một lớp đặt là Staff, có 3 thuộc tính Fullname, Age, Gender
        // tạo 2 constructor, 1 constructor gán giá trị ban đầu cho Fullname và 1 Constructor gán giá trị ban đầu cho Fullname và Age
        // tạo 2 đối tượng lần lượt sử dụng 2 constructor
        Staff Trung = new Staff("Vũ Thành Trung");
        Staff Trung_2 = new Staff("Vũ Thành Trung 2", 18);
    }
}

class Staff
{
    public string FullName;
    public int Age;
    public bool Gender;
    public Staff(string _FullName)
    {
        this.FullName = _FullName;
    }
    public Staff(string _FullName, int _Age)
    {
        this.FullName = _FullName;
        this.Age = _Age;
    }
}