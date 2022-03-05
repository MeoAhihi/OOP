class Person : IComparable
{
    private string _code = "";
    private string _name = "";
    private byte _age = 0;
    public string Code
    {
        get { return _code; }
        set { _code = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public byte Age
    {
        get { return _age; }
        set { _age = value; }
    }
    public Person(string code, string name, byte age)
    {
        Code = code;
        Name = name;
        Age = age;
    }
    public void input()
    {
        System.Console.WriteLine("Enter the person's code: ");
        Code = Console.ReadLine();
        System.Console.WriteLine("Enter the person's name: ");
        Name = Console.ReadLine();
        System.Console.WriteLine("Enter the person's age: ");
        Age = byte.Parse(Console.ReadLine());
    }
    
    public override string ToString()
    {
        return _code + ", " + _name + ", " + _age;
    }

    public int CompareTo(object obj)
    {
        var otherPerSon = obj as Person;
        return this.Age.CompareTo(otherPerSon.Age);
    }
}