using System;

namespace covert
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new Coordinator("cartesian", 12, 3);
            System.Console.WriteLine(A);
        }
    }
}
