using System;

namespace Worker
{
    class Worker: IComparable
    {
        private int id;
        private string firstName, lastName;
        private int product;
        public int ID
        {
            get { return id; }
            set { if (value > 0) id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { if (value != string.Empty) firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { if (value != string.Empty) lastName = value; }
        }
        public int Product
        {
            get { return product; }
            set { if (value > 0) product = value; }
        }
        public Worker()
        {
            id = 1;
            firstName = "N/A";
            lastName = "N/A";
            product = 0;
        }
        public Worker(int newID, string newFirstName, string newLastName, int newProductNumber)
        {
            id = 1;
            firstName = "N/A";
            lastName = "N/A";
            product = 0;

            ID = newID;
            FirstName = newFirstName;
            LastName = newLastName;
            Product = newProductNumber;
        }
        public float CalcSalary()
        {
            if (product < 200) return product * 0.5f;
            else if (product < 400) return 199 * 0.5f + (product - 199) * 0.55f;
            else if (product < 600) return 199 * 0.5f + 200 * 0.55f + (product - 399) * 0.6f;
            else return 199 * 0.5f + 200 * 0.55f + 200 * 0.6f + (product - 599) * 0.65f;
        }
        public void toString()
        {
            System.Console.WriteLine($"|{id,5}|{firstName,-10}|{lastName,-15}|{product,8}|{CalcSalary(),10}|");
        }
        public static void Title()
        {
            for (byte i = 0; i < 54; i++) System.Console.Write("*");
            System.Console.WriteLine("\n|{0, 5}|{1, -10}|{2, -15}|{3, 8}|{4, 10}|", "ID", "FIRST NAME", "LAST NAME", "#PRODUCT", "SALARY");
            for (byte i = 0; i < 54; i++) System.Console.Write("*");
            System.Console.WriteLine();
        }
        public static void End()
        {
            for (byte i = 0; i < 54; i++) System.Console.Write("*");
            System.Console.WriteLine("\n");
        }

        public int CompareTo(object obj)
        {
            var otherWorker = obj as Worker;
            return - this.product.CompareTo(otherWorker.product);
        }
    }
}
