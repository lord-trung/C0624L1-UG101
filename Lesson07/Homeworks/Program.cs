using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        #region While

        #region câu 1: hiển thị 20 số nguyên đầu tiên

        // int i = 1;
        // while (i <= 20)
        // {
        //     Console.Write(i + " ");
        //     i++;
        // }

        #endregion

        #region câu 2: tính tổng 20 số nguyên đầu tiên và hiển thị kết quả ra màn hình

        // int i = 1;
        // int num = 0;
        // while (i < 21)
        // {
        //     num += i;
        //     i++;
        // }
        // Console.Write("Tổng 20 số nguyên đầu tiên = " + num);

        #endregion

        #region câu 3: hiển thị các số chia hết cho 5 trong khoảng từ 1 đến 100

        // int i = 0;
        // while (i <= 100)
        // {
        //     if (i == 0)
        //     {
        //         i += 5;
        //     }
        //     else
        //     {
        //         if (i % 5 == 0)
        //         {
        //             Console.Write(i + " ");
        //             i += 5;
        //         }
        //     }
        // }

        #endregion

        #region câu 4: hiển thị các số nguyên chia hết cho 4 trong khoảng từ 1-100 theo thứ tự từ lớn đến nhỏ

        //   int i = 100;
        //     while (i >= 0)
        //     {
        //         if (i == 0)
        //         {
        //             i -= 4;
        //         }
        //         else
        //         {
        //             if (i % 4 == 0)
        //             {
        //                 Console.Write(i + " ");
        //                 i -= 4;
        //             }
        //         }
        //     }

        #endregion

        #region câu 5: viết chương trình nhập vào một số nguyên và kiểm tra số đó có phải là số nguyên tố hay ko? nếu phải thì hiển ra màn hình "Number là số nguyên tố" ngược lại thì hiện thị "Number không là số nguyên tố" với Number là giá trị được nhập từ bàn phím từ đầu

        // Console.Write("Nhập vào một số: ");
        // int num = Convert.ToInt32(Console.ReadLine());
        // int i = 2;
        // bool check = true;

        // if (num == 2)
        // {
        //     Console.WriteLine(num + "Là số nguyên tố");
        // }
        // else
        // {
        //     while(i < num)
        //     {
        //         if (num % i == 0)
        //         {
        //             check = false;
        //             break;
        //         }
        //         else
        //         {
        //             i++;
        //         }
        //     }
        //     Console.WriteLine(check == true ? (num + " là số nguyên tố") : (num + " không phải số nguyên tố"));
        // }

        #endregion

        #region câu 6: hiển thị 5 số chia hết cho 5 đầu tiên trong khoảng từ [100-400]

        // int i = 100;
        // int count = 0;
        // while (count < 5)
        // {
        //     if (i % 5 == 0)
        //     {
        //         Console.Write(i + " ");
        //         i += 5;
        //         count++;
        //     }
        //     else
        //     {
        //         i++;
        //     }
        // }

        #endregion

        #endregion

        #region Do...While

        #region câu 1: hiển thị 20 số nguyên đầu tiên

        // int i = 1;
        // do
        // {
        //     Console.Write(i + " ");
        //     i++;
        // }
        // while (i <= 20);

        #endregion

        #region câu 2: tính tổng 20 số nguyên đầu tiên và hiển thị kết quả ra màn hình

        // int i = 1;
        // int num = 0;

        // do
        // {
        //     num += i;
        //     i++;
        // }
        // while (i < 21);

        // Console.Write("Tổng 20 số nguyên đầu tiên = " + num);

        #endregion

        #region câu 3: hiển thị các số chia hết cho 5 trong khoảng từ 1 đến 100

        // int i = 0;

        // do
        // {
        //     if (i == 0)
        //     {
        //         i += 5;
        //     }
        //     else
        //     {
        //         if (i % 5 == 0)
        //         {
        //             Console.Write(i + " ");
        //             i += 5;
        //         }
        //     }
        // }
        // while (i <= 100);

        #endregion

        #region câu 4: hiển thị các số nguyên chia hết cho 4 trong khoảng từ 1-100 theo thứ tự từ lớn đến nhỏ

        // int i = 100;

        // do
        // {
        //     if (i == 0)
        //     {
        //         i -= 4;
        //     }
        //     else
        //     {
        //         if (i % 4 == 0)
        //         {
        //             Console.Write(i + " ");
        //             i -= 4;
        //         }
        //     }
        // }
        // while (i >= 0);

        #endregion

        #region câu 5: viết chương trình nhập vào một số nguyên và kiểm tra số đó có phải là số nguyên tố hay ko? nếu phải thì hiển ra màn hình "Number là số nguyên tố" ngược lại thì hiện thị "Number không là số nguyên tố" với Number là giá trị được nhập từ bàn phím từ đầu

        // Console.Write("Nhập vào một số: ");
        // int num = Convert.ToInt32(Console.ReadLine());
        // int i = 2;
        // bool check = true;

        // if (num == 2)
        // {
        //     Console.WriteLine(num + "Là số nguyên tố");
        // }
        // else
        // {
        //     do
        //     {
        //         if (num % i == 0)
        //         {
        //             check = false;
        //             break;
        //         }
        //         else
        //         {
        //             i++;
        //         }
        //     } while (i < num);

        //     Console.WriteLine(check == true ? (num + " là số nguyên tố") : (num + " không phải số nguyên tố"));
        // }

        #endregion

        #region câu 6: hiển thị 5 số chia hết cho 5 đầu tiên trong khoảng từ [100-400]

        int i = 100;
        int count = 0;

        do
        {
            if (i % 5 == 0)
            {
                Console.Write(i + " ");
                i += 5;
                count++;
            }
            else
            {
                i++;
            }
        }
        while (count < 5);

        #endregion

        #endregion

    }
}