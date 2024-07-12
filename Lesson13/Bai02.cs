namespace Lesson13;
using System.Text;

class Bai02
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // câu 2: Tiếp tục triển khai mã nguồn cho hàn InitCaroTable ở Bai01 để hiển thị ra màn hình với yêu cầu sau
        // Các giá có row = 0 thì sẽ hiển thị từ 1 đến n-1
        // Các giá trị có col = 0 thì sẽ hiển thị từ 1 đến n-1
        // các giá trị còn lại thì hiển thị dấu "-"
        InitCaroTable(15);
    }

    static void InitCaroTable(int n)
    {
        string[,] caroTable = new string[n, n];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == 0)
                {
                    caroTable[row, col] = row.ToString();
                }
                else
                {
                    if (row == 0)
                    {
                        caroTable[row, col] = col.ToString();
                    }
                    else
                    {
                        caroTable[row, col] = "-";
                    }
                }

            }
        }
    }
}