class PersonList
{
    private Person[] list = null;
    private int count = 0;
    public PersonList(int size)
    {
        if (size < 10) size = 10;
        list = new Person[size];
    }
    int find(string aCode)
    {
        for (int i = 0; i < count; i++)
        {
            if (aCode == list[i].Code) return i;
        }
        return -1;
    }
    public void add()
    {
        if (count == list.Length) System.Console.WriteLine("List is full");
        else
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

            list[count++] = new Person(code: newCode, name: newName, age: newAge);
            System.Console.WriteLine("New person have been added.");
        }
    }
    public void remove()
    {
        if (count == 0) System.Console.WriteLine("Empty list.");
        else
        {
            System.Console.Write("Enter the code of removed person: ");
            string removedCode = Console.ReadLine();
            int position = find(removedCode);
            if (position < 0) System.Console.WriteLine("This person does not exist");
            else
            {
                for (int i = position; i < count - 1; i++)
                {
                    list[i] = list[i + 1];
                }
                count--;
                System.Console.WriteLine("the person {0} was removed", removedCode);
            }
        }
    }
    public void update()
    {
        if (count == 0)
        {
            System.Console.WriteLine("Empty list");
        }
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
                System.Console.WriteLine("Enter the person's age: ");
                list[position].Age = byte.Parse(Console.ReadLine());

                System.Console.WriteLine("The person {0} was updated.", code);
            }
        }
    }
    public void print()
    {
        if (count == 0) System.Console.WriteLine("empty list");
        else
        {
            System.Console.WriteLine("LIST OF PEOPLE:");
            for (int i = 0; i < count; i++) System.Console.WriteLine(list[i]);
        }
    }
    public void sort() {
        Array.Sort(list);
    }
}