using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        #region Hiển thị tổng 20 số nguyên đầu tiên
        // int sum = 0;
        // for (int i = 0; i < 20; i++)
        // {
        //     sum += i;
        // }
        // Console.WriteLine("Tổng 20 số nguyên đầu tiên = " + sum); 
        #endregion

        #region  Hiển thị các số chia hết cho 5 trong khoảng từ 1-100
        // for (int i = 0; i <= 100; i+=5)
        // {
        //     if (i%5 == 0 && i != 0)
        //     {
        //         Console.Write (i + " ");
        //     }
        // }
        #endregion

        #region Hiển thị các số nguyên chia hết cho 4 trong khoảng từ 1-100 theo thứ tự từ lớn đến nhỏ

        // for (int i = 100; i > 0; i -= 4)
        // {
        //     Console.Write(i + " ");
        // }
        #endregion

        #region viết chương trình nhập vào một số nguyên và kiểm tra số đó có phải là số nguyên tố hay ko? Nếu phải thì hiển ra màn hình "Number là số nguyên tố" ngược lại thì hiện thị "Number không là số nguyên tố. với Number là giá trị được nhập từ bàn phím từ đầu.

        // Console.Write("Nhập vào giá trị ban đầu: ");
        // int firstNum = Convert.ToInt32(Console.ReadLine());

        // bool isPrimer = true;
        // if (firstNum < 2)
        // {
        //     isPrimer = false;
        // }
        // else
        // {
        //     for (int i = 2; i < firstNum; i++)
        //     {
        //         if (firstNum % i == 0)
        //         {
        //             isPrimer = false;
        //             break;
        //         }
        //     }
        // }

        // string result = isPrimer == true ? (firstNum + " Không phải số nguyên tố") : (firstNum + " Không phải số nguyên tố");
        // Console.WriteLine(result);

        // // if (isPrimer == true)
        // // {
        // //     Console.WriteLine(firstNum + " Là số nguyên tố");
        // // }
        // // else Console.WriteLine(firstNum + " Không phải số nguyên tố");

        #endregion

        #region hiển thị 5 số chia hết cho 5 đầu tiên trong khoảng từ [100-400]

        // int count = 0;
        // for (int i = 100; i <= 400; i += 5)
        // {
        //     if (i % 5 == 0)
        //     {
        //         Console.Write(i + " ");
        //         count++;
        //     }
        //     if (count == 5)
        //     {
        //         break;
        //     }
        // }

        #endregion
    
    }

}