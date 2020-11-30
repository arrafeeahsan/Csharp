using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class Faculty
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Faculty()
        {

        }
        public Faculty(string name, string id)
        {
            Name = name;
            Id = id;

        }
        public void ShowInfo()
        {
            Console.WriteLine("Name of Faculty : " + name);
            Console.WriteLine("ID of Faculty : " + id);
            Console.WriteLine();
        }
    }
}
