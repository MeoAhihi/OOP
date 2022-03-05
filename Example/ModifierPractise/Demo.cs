using System;
using RectNmsp;

namespace BoxNmsp
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.setSize(1, 2, 3);
            box.height = 10;
            box.price = 7;
            //box.weight = 9;
            System.Console.WriteLine("Volume: " + box.volume());
            var r = new Rectangle();
            r.setSize(1, 6);
            r.width = 3;
            //r.length = 9;
        }
    }
}
