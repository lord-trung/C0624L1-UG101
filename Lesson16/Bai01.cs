namespace Lesson16;

class Bai01
{
    static void Main(string[] args)
    {
        // Câu 1: tạo 1 lớp Product
        // trong lớp này có các properties: Title, Price, Brand
        // và một field: rate kiểu int
        // tạo 1 phương getter và setter để lấy thông tin của rate, cũng như cập nhật dữ liệu cho rate
        // sau đó các bạn tạo 1 object từ class Product và thực hiện 2 thao tác getter và setter

        Product Hat = new Product();
        Hat.Rate = 5;
        Console.Write(Hat.Rate);
    }
}