class Menu
{
    string[] hints;
    int n = 0;
    public Menu(int size)
    {
        if (size < 1) size = 10;
        hints = new string[size];
    }
    public void add(string aHint)
    {
        if (n < hints.Length)
        {
            hints[n++] = aHint;
        }
    }
    public int getChoice()
    {
        int result = 0;
        if (n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine((i+1) + "-" + hints[i]);
            }
            System.Console.Write("Please select an operation: ");
            result = int.Parse(Console.ReadLine());
        }
        return result;
    }
}