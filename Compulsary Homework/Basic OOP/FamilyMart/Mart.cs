class Product
{
    private readonly string id;
    private string name;
    private int price;
    private DateOnly MFG;
    private DateOnly EXP;
    readonly DateOnly today = DateOnly.FromDateTime(DateTime.Today);
    public Product(string ID, string Name, int Price, DateOnly mfg, DateOnly exp)
    {
        if (ID != string.Empty) id = ID;
        setName(Name);
        setPrice(Price);
        setMFG(mfg);
        setEXP(exp);
    }
    public Product(string id)
    {
        if (id == string.Empty) ;//thoat khoi ctor hoac gan gia tri null cho obj
        else
        {
            name = "xxx";
            price = 0;
            MFG = today;
            EXP = today;
        }
    }
    public void setName(string newName)
    {
        if (newName != string.Empty) name = newName;
        else name = "xxx";
    }
    public void setPrice(int newPrice)
    {
        if (newPrice > 0) price = newPrice;
        else price = 0;
    }
    public void setMFG(DateOnly newMFG)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        if (newMFG < today) MFG = newMFG;
        else MFG = today;
    }
    public void setEXP(DateOnly newEXP)
    {
        if (newEXP > MFG) EXP = newEXP;
        else EXP = MFG;
    }
    public string getID() { return this.id; }
    public string getName() { return this.name; }
    public int getPrice() { return this.price; }
    public DateOnly getMFG() { return this.MFG; }
    public DateOnly getEXP() { return this.EXP; }
    public bool isOutOfDate()
    {
        return (EXP < today);
    }
    public override string ToString()
    {
        string note = (isOutOfDate() ? "Out of date" : "");
        return $"|{id,5}|{name,-20}|{price,7}VND|{MFG,15}|{EXP,15}|{note,15}|";
    }
    public static void Title() {
        HorizontalLine();
        System.Console.WriteLine("|{0,5}|{1,-20}|{2,10}|{3,15}|{4,15}|{5,15}|", "ID", "Product", "Price", "MFG", "EXP", "Note");
        HorizontalLine();
    }
    public static void HorizontalLine() {
        for (int i = 0; i < 87; i++) { System.Console.Write("*"); }
        System.Console.WriteLine();
    }
}