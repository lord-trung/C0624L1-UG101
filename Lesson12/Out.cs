namespace Lesson12;
using System.Text;

class Out
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        #region 
        // Console.Write("Enter Number: ");
        // string value = Console.ReadLine();
        // int.TryParse(value, out int num);

        // Console.WriteLine(num);

        // // Nếu parse thất bại => num = 0
        // // Trong trường hợp boolean, nếu parse thành công = true, thất bại = false
        #endregion

        int[] numbers = new int[5] { 0, 3, 5, 7, 8 };
        int value = 8;
        string result = findValue(numbers, value, out int pos);
        Console.WriteLine($"Result = {result}");
        Console.WriteLine($"Position = {pos}");
    }


    // Kiểm tra xem value có trong mảng numbers hay không
    // Nếu có thì true, không thì false
    static string findValue(int[] numbers, int value, out int position)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == value)
            {
                position = i;
                return "Exist";               
            }
        }
        position = -1;
        return "Non exist";
    }
}