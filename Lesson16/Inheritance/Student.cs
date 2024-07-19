namespace Inheritance;

class Student : Person
{
    public int studentCode { get; set; }

    public Student() { }
    public Student(string _FullName)
    {
        this.fullName = _FullName;
    }
}