using Lesson15;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        // Khai báo đối tượng: <class_name> <object_name> = new <class_name> ();
        Car Toyota = new Car();

        // Gán thuộc tính cho đối tượng - <object_name>.<property>
        Toyota.Color = "Red";
        Toyota.Price = 10000;
        Toyota.Weight = 2000;

        // Lấy thông tin hay thuộc tính của đối tượng
        Console.Write($"{Toyota.Color}\n{Toyota.Price}\n{Toyota.Weight}");
    }
}