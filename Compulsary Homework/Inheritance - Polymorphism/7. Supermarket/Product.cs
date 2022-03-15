abstract class Product {
    //Fields
    private readonly string _id; //ma hang
    private string _name = ""; //ten hang
    private int _unitPrice; //don gia
    private int _stock; //hang ton kho


    //Properties
    public string Id => _id;
    public string Name { get => _name; set => _name = value != "" ? value : "xxx"; }
    public int UnitPrice { get => _unitPrice; set => _unitPrice = value > 0 ? value : 0; }
    public int Stock { get => _stock; set => _stock = value > 0 ? value : 0; }

    //Constructor
    public Product(string id, string name, int unitPrice, int stock)
    {
        _id = id;
        Name = name;
        UnitPrice = unitPrice;
        Stock = stock;
    }
    abstract internal string Status();
    public abstract override string ToString();
}