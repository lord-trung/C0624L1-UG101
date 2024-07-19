namespace Lesson14;

class Bai03
{
    static void Main(string[] args)
    {
        // câu 3: các bạn hãy tạo các lớp mô phỏng lại thiết kế này
        // https://www.researchgate.net/profile/Philip-Bernstein/publication/221268945/figure/fig1[…]668989067907078@1536510831069/An-inheritance-hierarchy.png
    }
}

class Personbai03
{
    public int id { get; set; }
    public string name { get; set; }
}

class CustomerBai03 : Personbai03
{
    public int account { get; set; }
}

class EmployeeBai03 : Personbai03
{
    public int salary { get; set; }
    public DateTime hire { get; set; }
}

class FullTimeBai03 : EmployeeBai03
{
    public bool exempt { get; set; }
}

class PartTimeBai03 : EmployeeBai03
{
    public float hour { get; set; }
}