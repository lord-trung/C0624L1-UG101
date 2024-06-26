using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.Write("Nhập a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập c = ");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Đây không phải phương trình bậc 2");
        }
        else
        {
            double d = (b * b) - (4 * a * c);
            double x, y;

            if (d != 0)
            {
                if (d < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
                else
                {
                    x = (-b + Math.Sqrt(d)) / (2 * a);
                    y = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("Phương trình có 2 nghiệm x1 = " + x + " và x2 = " + y);
                }
            }
            else
            {
                x = -(b / (2 * a));
                Console.WriteLine("Phương trình có nghiệm kép x = " + x);
            }
        }

    }
}