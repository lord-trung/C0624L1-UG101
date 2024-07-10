namespace Lesson12;
using System.Text;

class Naming
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Naming paramenter
        // GetProfile("Vũ Thành Trung", 23, true, DateTime.Parse("09/08/1998"), "Hà Nội");
        GetProfile(gender: true, address: "Hà Nội", fullName: "Vũ Thành Trung", dob: DateTime.Parse("09/08/1998"), age: 23);
    }

    static void GetProfile(string fullName, int age, bool gender, DateTime dob, string address)
    {
        Console.WriteLine("Full information:");
        Console.WriteLine($"Full name: {fullName},\nAge: {age}\nGender: {gender}\nDob: {dob.Date}\nAddress: {address}");
    }
}