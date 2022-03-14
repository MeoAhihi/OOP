public class TextBook : Book
{
    private bool _isNew;
    public TextBook(string code, DateOnly pruchaseDate, int price, int numOfBooks, string publisher, bool status)
        : base(code, pruchaseDate, price, numOfBooks, publisher)
    {
        IsNew = status;
    }
    public bool IsNew { get => _isNew; set => _isNew = value; }
    public override int TotalPrice()
    {
        return (_isNew ? base.TotalPrice() : base.TotalPrice() / 2);
    }
    public override string ToString()
    {
        return $"|{Code,10}|{PurchaseDate,15}|{Price,10: 0,000}|{NumOfBooks,10}|{Publisher,-20}|{TotalPrice(),20: 0,000}|";
    }
}