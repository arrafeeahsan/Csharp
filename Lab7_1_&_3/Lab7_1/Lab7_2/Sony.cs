using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Sony : Calculator,IBasicCalculator, IScientificCalculator
    {
        public Sony() { }
        public Sony(string name, string model):base(name, model) { }

        public void Division(int x, int y)
        {
            int div = x / y;
            Console.WriteLine("DIVISION: " + div);
        }

        public void Log(double x)
        {
            double log = (double)Math.Log(x);
            Console.WriteLine("Log of " + x + " is: " + log);
        }

        public void Multiplication(int x, int y)
        {
            int multi = x * y;
            Console.WriteLine("MULTIPLICATION: " + multi);
        }

        public void Power(double x, double y)
        {
            double power = Math.Pow(x,y);
            Console.WriteLine(x + " to the power " + y + " is: " + power);
        }

        public void Sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("SUB: " + sub);
        }

        public void Sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("SUM: " + sum);
        }
    }
}
