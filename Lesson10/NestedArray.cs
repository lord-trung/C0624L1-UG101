namespace Lesson10;
using System.Text;

class NestedArray
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        #region Khởi tạo mảng đa chiều

        // string[][] class_gu_101 = new string[4][]
        // {
        //     new string[3] {"Luân", "Duy", "Nhi"},
        //     new string[3] {"Chánh","Duy","Tuấn"},
        //     new string[3] {"Tuân", "Trung", "Anh"},
        //     new string[4] {"Thịnh", "Duy","Điền","Bảo"},
        // };

        // // Hiển thị tất cả các giá trị trong mảng đa chiều lên màn hình
        // for (int team = 0; team < class_gu_101.Length; team++)
        // {
        //     Console.Write($"Các thành viên trong nhóm {team + 1}: ");
        //     for (int member = 0; member < class_gu_101[team].Length; member++)
        //     {
        //         Console.Write($"{class_gu_101[team][member]} / ");
        //     }
        //     Console.Write("\n");
        // }
        
        #endregion

        #region Khởi tạo mảng đa chiều cách 2

        // // Tạo mảng có 3 phần tử, mỗi phần từ là một mảng chứa 5 phần tử
        // double[,] scores = new double[3, 5]{
        //     { 0, 1, 2, 3, 4},
        //     { 6, 7, 8, 9, 10},
        //     { 11, 12, 13, 14, 15},
        // };

        // Console.WriteLine($"Row = {scores.GetLength(0)}"); // Row = 3
        // Console.WriteLine($"Collum = {scores.GetLength(1)}"); // Collum = 5

        // // Tạo mảng có 2 phần tử, mỗi phần từ là một mảng chứa 3 phần tử con, mỗi phần tử con là một mảng chứa 4 phần tử
        // double[,,] scores2 = new double[2, 3, 4]
        // {
        //     {
        //         { 0, 1, 2, 3},
        //         { 4, 5, 6, 7},
        //         { 8, 9, 10, 11},
        //     },
        //     {
        //         { 12, 13, 14, 15},
        //         { 16, 17, 18, 19},
        //         { 20, 21, 22, 23}
        //     }
        // };

        #endregion

        // Tạo ra một matrix 5x7 với các giá trị trong matrix được sinh ra ngẫu nhiên trong khoảng 10-90
        int [,] matrix = new int[5,7];

        Random random = new Random(); // Khai báo giá trị ngẫu nhiên

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = random.Next(10, 90); // Tạo giá trị ngẫu nhiên trong khoảng 10-90
                Console.Write($"{matrix[row, col]}\t");
            }
            Console.WriteLine();
        }


    }
}