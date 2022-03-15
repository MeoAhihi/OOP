class Electronic : Product
{
    //Fields
    private byte _guarantee; //thoi gian bao hang (tinh theo thang)
    private float _power; //cong suat
    private const float _vat = 0.1f; //Thue VAT

    //Properties
    public byte Guarantee { get => _guarantee; set => _guarantee = value; }
    public float Power { get => _power; set => _power = value > 0 ? value : 0; }

    //Constructor
    public Electronic(string id, string name, int unitPrice, int stock, byte guarantee, float power) 
        : base(id, name, unitPrice, stock)
    {
        Guarantee = guarantee;
        Power = power;
    }
    internal override string Status() => Stock < 3 ? "Good selling" : "---";
    
    public override string ToString()
    {
        return $"|{Id,10}|{Name,30}|{"Electronic",20}|{UnitPrice,20 : 0,000}|{Stock,10}|{Status(),20}|";
    }
}