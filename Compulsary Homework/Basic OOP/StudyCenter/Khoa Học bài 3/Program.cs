using System;

namespace Khoa_Học_bài_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var h1 = new Tamgiac(3,4,5);
            var h2 = new Tamgiac(12,12,12);
            var h3 = new Tamgiac(9,9,12);
            var h4 = new Tamgiac();
            System.Console.Write("MA="); h4.setma(float.Parse(Console.ReadLine()));
            System.Console.Write("MB="); h4.setmb(float.Parse(Console.ReadLine()));
            System.Console.Write("MC="); h4.setmc(float.Parse(Console.ReadLine()));

            
            h1.Kiemtratamgiac();
            h1.Chuvitamgiac();
            h1.dientichtamgiac();
            h2.Kiemtratamgiac();
            h3.Kiemtratamgiac();
            h4.Kiemtratamgiac();
            h4.Chuvitamgiac();
            h4.dientichtamgiac();

            Tamgiac.title();
            h1.ToString();
            h2.ToString();
            h3.ToString();
            h4.ToString();
            Tamgiac.ending();

            System.Console.WriteLine();
        }
    }
}
