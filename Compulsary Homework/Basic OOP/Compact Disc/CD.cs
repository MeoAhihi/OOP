class CD
{
    private int _code;
    private string _title;
    private int _numOfSongs;
    private float _price;
    public int Code
    {
        get { return _code; }
        set { _code = (value > 0 ? value : 999999); }
    }
    public string Title
    {
        get { return _title; }
        set { _title = (value != string.Empty ? value : "#UNDEFINED"); }
    }
    public int NumOfSongs
    {
        get { return _numOfSongs; }
        set { _numOfSongs = (value > 0 ? value : 0); }
    }
    public float Price
    {
        get { return _price; }
        set { _price = (value > 0 ? value : 0); }
    }
    public CD( )
    {
        _code = 999999;
        _numOfSongs = 0;
        _price = 0;
        _title = "#UNDEFINED";
    }
    public CD(int code, int numOfSongs, float price, string title)
    {
        Code = code;
        NumOfSongs = numOfSongs;
        Price = price;
        Title = title;
    }
}