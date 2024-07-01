// namespace Lesson08;
// using System.Text;

// class Bai2
// {
//     static void Main(string[] args)
//     {
//         Console.InputEncoding = Encoding.Unicode;
//         Console.OutputEncoding = Encoding.Unicode;


//         Console.Write("Nhập số từ 2-9: ");

//         int num = 0;
        
//         int.TryParse(Console.ReadLine(), out num);

//         // int num = Convert.ToInt32(Console.ReadLine());

//         while (num < 2 || num > 9)
//         {
//             Console.Clear();
//             Console.WriteLine("Nhập số từ 2-9: ");
//             // num = Convert.ToInt32(Console.ReadLine());
//             int.TryParse(Console.ReadLine(), out num);
//         }

//         Console.WriteLine($"bảng cửu chương của số {num} là: ");

//         for (int i = 1; i <= 10; i++)
//         {
//             Console.WriteLine($"{num} x {i} = {num * i}");
//         }

//     }
// }