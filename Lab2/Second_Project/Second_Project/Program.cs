using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int l =0; l < 100; l++)
            {
                if(l % 2 == 0)
                {
                    Console.WriteLine("Even Number: " + l);
                }
                else
                {
                    Console.WriteLine("Odd Number: " + l);
                }
            }

            Console.WriteLine("====================================");


            int rows = 4;
            int cols = 6;
            int i, j, k = 1;
            
            for(i = 1; i <= rows; i++)
            {
                for(j = 1; j <= cols; j++)
                {
                    if (k == 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("0");
                    }

                    k = k * -1;
                }

                if(cols % 2 == 0)
                {
                    k = k * -1;
                }

                Console.WriteLine("");
            }

            Console.WriteLine("====================================");

            int e = 1;
            for(int r = 0; r < 5; r++)
            {
                for(int t = 0; t<5; t++)
                {
                    Console.Write(e+t);
                }
                Console.WriteLine("");
                e++;
            }

            Console.WriteLine("====================================");

            int o = 0, p = 0;
            for(int q=1; q<=100; q++)
            {
                if (q % 2 == 1)
                    o = o + q;
                else
                    p = p + q;
            }
            Console.WriteLine("Addition of odd numbers: " + p); 
            Console.WriteLine("Addition of even numbers: " + o);

            Console.WriteLine("====================================");

            for (int d = 1; d <= 5; d++)
            {
                for (int s = 1; s <= d; s++)
                {
                    if (s == d)
                        Console.Write(d);
                    else 
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("====================================");

            int m = 5, c;
            int factorial = 1;
            for (c = 1; c <= m; c++)
            {
                factorial = factorial * c;
            }

            Console.WriteLine(factorial);

            Console.WriteLine("====================================");

            int h=1;
            for(int row=1; row<=9; row++)
            {
                for(int col = 1; col<=h; col++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                if (row < 5)
                    h++;
                else
                    h--;
            }

        }
    }
}
