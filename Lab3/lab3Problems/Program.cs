using System;

namespace lab3Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Somudro";
            s.Id = "546";
            s.Department = "CSE";
            s.Cgpa = 3.88f;
            s.ShowInfo();


            Course c = new Course();
            c.CourseName="OOP 2";
            c.CourseCradit = 3;
            c.CourseCode = "CSE 2230";
            c.ShowInfo();

            Account a = new Account();
            a.AccountName = "Mr.Somudro";
            a.AccountId = "556c";
            a.Balance = 10000;
            a.showInfo();
            a.Deposit(8000);
            a.Withdraw(6000);

            Triangle t = new Triangle();
            t.BottomSide=15;
            t.LeftSide=6;
            t.RightSide = 8;
            t.ShowInfo();
            t.TestTriangle();
        }
    }
}
