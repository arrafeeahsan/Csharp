using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    abstract class Calculator
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public Calculator() { }
        public Calculator(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Model: " + Model);
        }

    }
}
