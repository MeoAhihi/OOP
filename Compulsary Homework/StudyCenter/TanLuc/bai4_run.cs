using System;

namespace TanLuc
{
    internal class Bai4
    {
        static void Main(string[] args)
        {
            Vehicle test = new Vehicle("Luc", "Honda", 100, 35000000);
            Console.WriteLine(test);

            Vehicle test2 = new Vehicle("Phong", "Yamaha", 300, 35000000);
            Console.WriteLine(test2);

            Vehicle test3 = new Vehicle("Hien", "Honda", 150, 35000000);
            Console.WriteLine(test3);

            Vehicle test4 = new Vehicle("Hoc", "Honda", 80, 35000000);
            Console.WriteLine(test4);

            Console.ReadKey();
        }
    }
}