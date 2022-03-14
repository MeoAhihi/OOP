class BookList
{
    List<Book> list = new List<Book>();
    private int _totalTxtBkPrice = 0;
    private int _numOfRefBooks = 0;
    private int _totalRefBkPrice = 0;
    private int _totalPrice = 0;
    public void AddBook(Book book) => list.Add(book);
    public void Line()
    {
        for (int i = 0; i < 92; i++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
    public void Title()
    {
        Line();
        System.Console.WriteLine($"|{"Book code",10}|{"Pruchase Date",15}|{"Price",10}|{"#Books",10}|{"Publisher",20}|{"Total Price",20}|");
        Line();
    }
    public void PrintAll()
    {
        System.Console.WriteLine("\nLIST OF ALL BOOKS");
        Title();
        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        }
        Line();
        InfoCalc();
        System.Console.WriteLine(
            "|{0, -90}|\n|{1, -90}|\n|{2,-90}|\n|{3, -90}|",
            "Textbook total price: " + $"{ _totalTxtBkPrice: 0,000}",
            "Referance book total price: " +  $"{ _totalRefBkPrice: 0,000}",
            "Total price: " +  $"{ _totalPrice: 0,000}",
            "Average price of reference books: " + $"{RefBkArvrPrice(): 0,000}"
        );
        Line();
        System.Console.WriteLine();
    }
    public void Print1Publisher() {
        System.Console.Write("You're finding books of: ");
        string publisher = Console.ReadLine().Trim().ToLower();
        System.Console.WriteLine("\nList of {0}'s books", publisher);
        Title();
        foreach (var item in list)
        {
            if (item.Publisher.ToLower() == publisher) System.Console.WriteLine(item);
        }
        Line();
        System.Console.WriteLine();
    }
    private void InfoCalc()
    {
        foreach (var item in list)
        {
            _totalPrice += item.TotalPrice();
            if (item is TextBook) _totalTxtBkPrice += item.TotalPrice();
            else if (item is RefBook)
            {
                _totalRefBkPrice += item.TotalPrice();
                _numOfRefBooks += item.NumOfBooks;
            }
        }
    }
    private int RefBkArvrPrice() => (_numOfRefBooks != 0 ? _totalRefBkPrice / _numOfRefBooks : 0);
}