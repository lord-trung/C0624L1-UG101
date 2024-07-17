namespace Lesson15;

class Bai01
{
    static void Main(string[] args)
    {
        // Câu 1: Sử dụng kiến thức OOP tạo lớp Shoe gồm 3 thuộc tính: Size, Price, Brand
        // Sau đó tạo 2 đối tượng lần lượt là adidas và nike và gán các giá trị cho thuộc tính tương ứng

        Shoes Adidas = new Shoes(30, 100);
        Shoes Nike = new Shoes(20, 150);
        Adidas.Brand = "Adidas";
        Nike.Brand = "Nike";

        // Console.WriteLine($"Adidas - size: {Adidas.Size}, price: {Adidas.Price}, brand: {Adidas.Brand}");
        // Console.WriteLine($"Nike - size: {Nike.Size}, price: {Nike.Price}, brand: {Nike.Brand}");
        Adidas.GetInfo();
        Nike.GetInfo();
    }
}