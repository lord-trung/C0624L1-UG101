using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {        
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Vẽ 1 hình chữ nhật 10 x 15 trên màn hình
        // row = 10
        // element  15 sử dụng

        // int rows = 10, elements = 15;

        #region for...      

        // for (int row = 1; row <= rows; row++)
        // {
        //     Console.Write($"{row}\t"); // \t = tab = 1.27cm
        //     for (int element = 1; element < elements; element++)
        //     {
        //         Console.Write("*");
        //     }
        //     Console.Write("\n"); // \n = new line
        // }

        #endregion

        #region while...

        // int row = 1, element = 1;

        // while(row <= rows)
        // {
        //     element = 1;
        //     while(element <= elements)
        //     {                   
        //         Console.Write("*");
        //         element++;
        //     }
        //     Console.Write("\n");
        //     row++;
        // }

        #endregion

        #region Do...While

        // int row = 1, element = 1;

        // do
        // {
        //     element = 1;

        //     do
        //     {
        //         Console.Write("*");
        //         element++;
        //     } 
        //     while (element <= elements);

        //     Console.Write("\n");
        //     row++;
        // } 
        // while (row <= rows);

        #endregion

        #region Vẽ hình chữ nhật rỗng ruột

        // int row = 1, element = 1;

        // for (row = 1; row <= rows; row++)
        // {
        //     if (row == 1 || row == rows)
        //     {
        //         for (element = 1; element <= elements; element++)
        //         {
        //             Console.Write("*");
        //         }
        //     }
        //     else
        //     {
        //         for (element = 1; element <= elements; element++)
        //         {
        //             if (element == 1 || element == elements)
        //             {
        //                 Console.Write("*");
        //             }
        //             else Console.Write(" ");
        //         }
        //     }

        //     Console.Write("\n");
        // }

        #endregion

    }
}