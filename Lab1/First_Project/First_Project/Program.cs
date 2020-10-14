using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! ");
            Console.WriteLine("Arrafi Ahsan Somudro");

            int a = 10;
            int b = 5;
            int sum = a + b;
            Console.WriteLine("Sum of two numbers: " + sum);
            int div = a / b;
            Console.WriteLine("Division of two numbers: " + div);
            int statement1 = -5 + 8 * 6;
            int statement2 = (55 + 9) % 9;
            int statement3 = 20 + -3*5 / 8;
            int statement4 = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("Statement1: " + statement1);
            Console.WriteLine("Statement2: " + statement2);
            Console.WriteLine("Statement3: " + statement3);
            Console.WriteLine("Statement4: " + statement4);

            int c = 20;
            int d = 10;
            int addition = c + d;
            int multiplication = c * d;
            int substraction = c + d;
            int division = c / d;
            int remainder = c % d;
            Console.WriteLine("Addition of two numbers: " + addition);
            Console.WriteLine("Multiplication of two numbers: " + multiplication);
            Console.WriteLine("Substraction of two numbers: " + substraction);
            Console.WriteLine("Division of two numbers: " + division);
            Console.WriteLine("Remainder of two numbers: " + remainder);

            double expression = (25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5);
            Console.WriteLine("The output of the specified Expression: " + expression);

            double width = 5.5;
            double height = 8.5;
            double area = width * height;
            double perimeter = 2 * (width * height);
            Console.WriteLine("Area is 5.5 * 8.5 = " + area);
            Console.WriteLine("Perimeter is 2 * (5.5 * 8.5) = " + perimeter);



        }
    }
}
