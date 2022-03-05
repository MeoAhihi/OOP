class PersonList
{
    private List<Person> list = new List<Person>();
    private int find(string aCode)
    {
        //Binary Search
        // int head = 0, tail = list.Count - 1, mid = (head + tail) / 2;
        // if (list[mid].Code == aCode) return mid;
        // else if (list[mid].Code < aCode)

        for (int i = 0; i < list.Count; i++)
        {
            if (aCode == list[i].Code) return i;
        }
        return -1;
    }
    public void add()
    {
        int position = -1;
        string newCode = "";
        do
        {
            System.Console.Write("Enter the person's code: ");
            newCode = Console.ReadLine();
            position = find(newCode);
            if (position >= 0) System.Console.WriteLine("\tThis code existed!");

        } while (position >= 0);

        System.Console.Write("Enter the person's name: ");
        string newName = Console.ReadLine();
        System.Console.Write("Enter the person's age: ");
        byte newAge = byte.Parse(Console.ReadLine());

        list.Add(new Person(newCode, newName, newAge));
        System.Console.WriteLine("New person have been added.");
    }
    public void remove()
    {
        if (list.Count == 0) System.Console.WriteLine("Empty list.");
        else
        {
            System.Console.Write("Enter the code of removed person: ");
            string removedCode = Console.ReadLine();
            int position = find(removedCode);
            if (position < 0) System.Console.WriteLine("This person does not exist");
            else
            {
                list.RemoveAt(position);
                System.Console.WriteLine("the person {0} was removed", removedCode);
            }
        }
    }
    public void update()
    {
        if (list.Count == 0) System.Console.WriteLine("Empty list");
        else
        {
            System.Console.Write("Enter the code of updated person: ");
            string code = Console.ReadLine();
            int position = find(code);
            if (position < 0) System.Console.WriteLine("This person does not exist");
            else
            {
                System.Console.Write("Enter the person's name: ");
                list[position].Name = Console.ReadLine();
                System.Console.Write("Enter the person's age: ");
                list[position].Age = byte.Parse(Console.ReadLine());

                System.Console.WriteLine("The person {0} was updated.", code);
            }
        }
    }
    public void print()
    {
        if (list.Count == 0) System.Console.WriteLine("empty list");
        else
        {
            System.Console.WriteLine("LIST OF PEOPLE:");
            foreach (var p in list) System.Console.WriteLine(p);
        }
    }
    public void sort()
    {
        list.Sort();
    }
}