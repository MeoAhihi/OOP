public class Book {
    private string _code = "";
    private DateOnly _purchaseDate;
    private int _price;
    private int _numOfBooks;
    private string _publisher = "";

    public Book(string code, DateOnly purchaseDate, int price, int numOfBooks, string publisher)
    {
        Code = code;
        PurchaseDate = purchaseDate;
        Price = price;
        NumOfBooks = numOfBooks;
        Publisher = publisher;
    }

    public string Code { get => _code; set => _code = (value == "" ? "A0000" : value); }
    public DateOnly PurchaseDate { get => _purchaseDate; set => _purchaseDate = value; }
    public int Price { get => _price; set => _price = (value > 0 ? value : 0); }
    public int NumOfBooks { get => _numOfBooks; set => _numOfBooks = (value > 0 ? value : 0); }
    public string Publisher { get => _publisher; set => _publisher = (value == "" ? "NXB Khang Viet" : value); }

    public virtual int TotalPrice() => _numOfBooks * _price;
    public override string ToString()
    {
        return $"|{Code,10}|{PurchaseDate,15}|{Price,10}|{NumOfBooks,10}|{Publisher,-20}|{TotalPrice(),10}|";
    }
}