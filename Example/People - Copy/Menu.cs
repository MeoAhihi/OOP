class Menu
{
    List<string> hints = new List<string>();

    public void add(string aHint)
    {
        hints.Add(aHint);
    }
    public int getChoice()
    {
        int result = 0;
        if (hints.Count > 0)
        {
            byte i = 1;
            foreach (var hint in hints)
            {
                System.Console.WriteLine(i + "-" + hint);
                i++;
            }
            System.Console.Write("Please select an operation: ");
            result = int.Parse(Console.ReadLine());
        }
        return result;
    }
}