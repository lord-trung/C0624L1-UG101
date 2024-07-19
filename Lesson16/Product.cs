class Product
{
    public string Title;
    public int Price;
    public string Brand;
    int rate;
    
    public int Rate
    {
        get => rate;
        set => rate = value;
    }

    // public string Rate
    // {
    //     get
    //     {
    //         return $"{rate} stars";
    //     }
    //     set
    //     {
    //         rate = int.Parse(value);
    //     }
    // }

    // public int GetRate()
    // {
    //     return Rate;
    // }
    // public void SetRate(int _Rate)
    // {
    //     this.Rate = _Rate;
    // }

    public Product() { }
    public Product(string _Title, string _Brand)
    {
        this.Title = _Title;
        this.Brand = _Brand;
    }
    public Product(string _Title, int _Price, int _Rate)
    {
        this.Title = _Title;
        this.Price = _Price;
        Rate = _Rate;
    }
}