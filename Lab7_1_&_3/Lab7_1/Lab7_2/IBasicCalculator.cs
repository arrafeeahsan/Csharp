using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    interface IBasicCalculator
    {
        void Sum(int x, int y);
        void Sub(int x, int y);
        void Multiplication(int x, int y);
        void Division(int x, int y);
    }
}
