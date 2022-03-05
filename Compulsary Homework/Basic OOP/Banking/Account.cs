class Account
{
    private long _accountNumber;
    private string _name;
    private double _balance;
    private readonly double rate = 0.035;
    public Account()
    {
        _accountNumber = 999999;
        _name = "unknown";
        _balance = 50000;
    }
    public Account(long accNum, string Name, double Balance)
    {
        if (accNum > 0) _accountNumber = accNum; else _accountNumber = 999999;
        if (Name != string.Empty) _name = Name; else _name = "unknown";
        if (Balance >= 50000) _balance = Balance; else _balance = 50000;
    }
    public long getAccountNumber() { return _accountNumber; }
    public double getBalance() { return _balance; }
    public bool deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            return true;
        }
        else return false;
    }
    public bool withdraw(double amount, double fee)
    {
        if (amount > 0 && amount + fee <= _balance)
        {
            _balance -= amount + fee;
            return true;
        }
        else return false;
    }
    public void addInterest() {
        _balance += _balance * rate;
    }
    public bool transfer(ref Account anotherAcc, double amount) {
        if (amount > 0 && amount < _balance) {
            _balance -= amount;
            anotherAcc._balance += amount;
            return true;
        }
        else return false;
    }
    public override string ToString()
    {
        return $"|{_accountNumber,10}|{_name,20}|{_balance,15}|";
    }
    public static void Title() {
        System.Console.WriteLine($"{"account", 10}|");
    }
}