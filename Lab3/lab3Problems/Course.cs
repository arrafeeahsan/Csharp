using System;
using System.Collections.Generic;
using System.Text;

namespace lab3Problems
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCradit;

        public Course()
        {
            
        }
        public string CourseName
        {
            set{ courseName=value; }
        }
        public string CourseCode
        {
            set { courseCode = value; }
        }
        public int CourseCradit
        {
            set { courseCradit = value; }
        }


        public void ShowInfo()
        {
            Console.WriteLine("Course name : " + courseName);
            Console.WriteLine("Course id : " + courseCode);
            Console.WriteLine("Course Cradit : " + courseCradit);
            Console.WriteLine(" ");

        }
    }
}
