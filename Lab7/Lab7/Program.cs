using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Account sa = new SavingAccount("John Wick", "0233", 5000);
            sa.ShowInfo();
            Console.WriteLine();
            sa.Deposit(4000);
            sa.Withdraw(100);
            sa.Withdraw(100);
            sa.Withdraw(100);
            sa.Withdraw(100);
            sa.Withdraw(100);

            Console.WriteLine(" ");


            Account ssa = new SpecialSavings("Somudro", "023", 2000);



            ssa.ShowInfo();
            ssa.Withdraw(2000);

            Console.WriteLine("\n");
            ssa.Withdraw(500);
            ssa.Withdraw(2000);

            Account fa = new FixedAccount("Arrafi", "026", 3000, 2);

            fa.Withdraw(2000);

            Account oa = new Overdraft("Ahsan", "236", 9000);
            oa.ShowInfo();
            oa.Withdraw(10000);

            oa.Withdraw(20000);


        }
    }
}
