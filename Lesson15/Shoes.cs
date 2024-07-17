namespace Lesson15;

class Shoes 
{
    internal int Size;
    internal int Price;
    internal string Brand;

    // Tạo contructor
    // <access_modifier> <class_name>(properties){}
    public Shoes(int _Size, int _Price)
    {
        this.Size = _Size;
        this.Price = _Price;
    }

    internal void GetInfo()
    {
        Console.WriteLine($"brand: {this.Brand}, size: {this.Size}, price: {this.Price}");
    }
}