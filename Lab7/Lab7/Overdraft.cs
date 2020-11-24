using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class Overdraft : Account
    {

        private int overdraftLimit = 1;

        public int OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }

        public Overdraft(string name, string id, double balance) : base(name, id, balance)
        {

        }
        override public void Deposit(double amount)
        {

            Balance = Balance + amount;

        }

        public override void Withdraw(double amount)
        {

            if (amount >= Balance)
            {
                if (overdraftLimit <= 1)
                {
                    Console.WriteLine("");
                    Balance = Balance + amount;
                    Console.WriteLine("After overdraft " + amount + " Your balance is : " + Balance);
                    overdraftLimit++;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Already over drafed once in this month!");
                }
            }
            else if (Balance - amount <= Balance)
            {
                Console.WriteLine("");
                Balance -= amount;
                Console.WriteLine("You have enough amount to widhraw, no need  to over draft!");
                Console.WriteLine("After widthraw  balance is " + Balance);


            }
        }
    }


}



