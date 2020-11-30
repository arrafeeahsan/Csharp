using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty faculty1 = new Faculty("Tanvir Ahmed", "007");
            Faculty faculty2 = new Faculty("Hasibul Hasib", "008");
            Department department = new Department();
            department.AddFaculty(faculty1, faculty2);
            department.ShowAllFaculties();
            Console.WriteLine();

            var faculty = department.SearchFaculty("008");
            if (faculty != null)
            {
                department.RemoveFaculty(faculty);
            }

            department.ShowAllFaculties();
        }

    }
}
