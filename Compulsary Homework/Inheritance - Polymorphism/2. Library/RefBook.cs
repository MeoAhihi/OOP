class RefBook : Book
{
    private int _tax;

    public RefBook(string code, DateOnly pruchaseDate, int price, int numOfBooks, string publisher, int tax) 
        : base(code, pruchaseDate, price, numOfBooks, publisher)
    {
        Tax = tax;
    }

    public int Tax { get => _tax; set => _tax = value; }
    public override int TotalPrice() {
        return base.TotalPrice() + _tax;
    }
    public override string ToString()
    {
        return $"|{Code,10}|{PurchaseDate,15}|{Price,10: 0,000}|{NumOfBooks,10}|{Publisher,-20}|{TotalPrice(),20: 0,000}|";
    }
}