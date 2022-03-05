class Vehicle
{
    private string _owner;
    private string _type;
    private int _value;
    private int _xylanh;
    private int _tax;
    public Vehicle(string carOwner, string carType, int xylanh, int carValue)
    {
        setOwner(carOwner);
        setType(carType);
        setValue(carValue);
        setXylanh(xylanh);
    }
    public void setOwner(string carOwner)
    {
        this._owner = carOwner;
    }
    public void setType(string carType)
    {
        this._type = carType;
    }
    public void setValue(int carValue)
    {
        if (carValue < 0) { carValue = 0; }
        else
        {
            this._value = carValue;
        }
    }
    public void setXylanh(int xylanh)
    {
        if (xylanh < 0) { xylanh = 0; }
        else
        {
            this._xylanh = xylanh;
        }
    }
    public string getOwner(string carOwner)
    {
        return this._owner;
    }
    public string getType(string carType)
    {
        return this._type;
    }
    public int getValue(int carValue)
    {
        return this._value;
    }
    public int getXylanh(int xylanh)
    {
        return this._xylanh;
    }
    public int getTax(int tax)
    {
        this._tax = tax;
        if (100 > _xylanh)
        {
            tax = _value * 1 / 100;
        }
        if (100 <= _xylanh & 200 >= _xylanh)
        {
            tax = _value * 3 / 100;
        }
        if (200 < _xylanh)
        {
            tax = _value * 5 / 100;
        }
        return tax;
    }
    public override string ToString()
    {
        return String.Format($"{this._owner,-3} {this._type,-20} {this._xylanh,-14} {this._value,-11} {getTax(_tax),5}");
    }
}