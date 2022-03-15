class Crockery : Product
{
    //Fields
    private DateOnly _MFG; //ngay san xuat
    private DateOnly _importDate; //ngay nhap khau
    private const float _vat = 0.1f; //Thue VAT
    readonly DateOnly today = DateOnly.FromDateTime(DateTime.Today);

    //Properties
    public Crockery(string id, string name, int unitPrice, int stock, DateOnly mFG, DateOnly importDate)
        : base(id, name, unitPrice, stock)
    {
        MFG = mFG;
        ImportDate = importDate;
    }

    public DateOnly MFG { get => _MFG; set => _MFG = value < today ? value : today; }
    public DateOnly ImportDate { get => _importDate; set => _importDate = (value >= _MFG) && (value <= today) ? value : today; }
    internal override string Status() => (Stock > 50) && (_importDate.AddDays(10) < today) ? "Dificult to sell" : "---";
    
    public override string ToString()
    {
        return $"|{Id,10}|{Name,30}|{"Crockery",20}|{UnitPrice,20 : 0,000}|{Stock,10}|{Status(),20}|";
    }
}