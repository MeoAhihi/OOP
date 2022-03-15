class Food : Product
{
    //Fields
    private string _producer = "";
    private DateOnly _MFG;
    private DateOnly _EXP;
    private const float _vat = 0.05f; //thue VAT
    readonly DateOnly today = DateOnly.FromDateTime(DateTime.Today);

    //Properties
    public string Producer { get => _producer; set => _producer = value != "" ? value : "#undefined"; }
    public DateOnly MFG { get => _MFG; set => _MFG = value < today ? value : today; }
    public DateOnly EXP { get => _EXP; set => _EXP = value > _MFG ? value : _MFG; }

    //Constructor
    public Food(string id, string name, int unitPrice, int stock, string producer, DateOnly mFG, DateOnly eXP)
        : base(id, name, unitPrice, stock)
    {
        Producer = producer;
        MFG = mFG;
        EXP = eXP;
    }

    internal override string Status() => (Stock > 0) && (_EXP < today) ? "Dificult to sell" : "---";

    public override string ToString()
    {
        return $"|{Id,10}|{Name,30}|{"Food",20}|{UnitPrice,20 : 0,000}|{Stock,10}|{Status(),20}|";
    }
}