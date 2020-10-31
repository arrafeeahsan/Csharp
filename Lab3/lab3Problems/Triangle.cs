using System;
using System.Collections.Generic;
using System.Text;

namespace lab3Problems
{
    class Triangle
    {
        int x;
        int y;
        int z;

        public Triangle()
        {
           
        }
        public int BottomSide
        {

            set { x = value; }
        }
        public int LeftSide
        {

            set { y = value; }
        }
        public int RightSide
        {

            set { z = value; }
        }


        public void ShowInfo()
        {
            Console.WriteLine("Buttom  : " + x);
            Console.WriteLine("Left side : " + y);
            Console.WriteLine("Right side  : " + z);
        }

        public void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Equilateral triangle.\n");
            }
            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("Isosceles triangle.\n");
            }
            else
            {
                Console.WriteLine("Scalene triangle.\n");
            }
        }
    }
}
