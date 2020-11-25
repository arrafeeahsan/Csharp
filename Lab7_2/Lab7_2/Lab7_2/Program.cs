using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Casio c = new Casio("Casio", "fx100");
            c.ShowInfo();

            c.Sum(2, 2);
            c.Sub(2, 2);
            c.Division(2, 2);
            c.Multiplication(2,2);
            Console.WriteLine();

            Sony s = new Sony("Sony", "968ms");
            s.ShowInfo();
            s.Log(10);
            s.Power(6, 2);
        }
    }
}
