using System;
using System.Collections.Generic;
using System.Text;

namespace lab3Problems
{
    class Student
    {

         string name;
         string id;
         string department;
         float cgpa;

        public Student()
        {
        }
        public string Name
        {
            set { name = value; }
        }
        public string Id
        {
            set { id = value; }
        }
        public string Department
        {
            set { department = value; }
        }
        public float Cgpa
        {
            set { cgpa= value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("name  : " + name);
            Console.WriteLine("id : " + id);
            Console.WriteLine("department : " + department);
            Console.WriteLine("cgpa : " + cgpa);
            Console.WriteLine(" ");
        }
    }
}
