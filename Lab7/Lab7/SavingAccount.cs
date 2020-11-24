using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class SavingAccount : Account
    {

        private int transectionCount = 0;


        public int TransectionCount
        {
            get { return transectionCount; }
            set { transectionCount = value; }
        }

        public SavingAccount()
        {

        }
        public SavingAccount(string name, string id, double balance) : base(name, id, balance)
        {

        }


        public override void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("After deposit " + amount + " balance is " + Balance);
        }

        public override void Withdraw(double amount)
        {

            if (transectionCount <= 3)
            {
                if (this.Balance - amount >= 500)
                {
                    Balance = Balance - amount;
                    Console.WriteLine("Your balance is : " + Balance);
                    transectionCount++;

                }
                else
                {
                    Console.WriteLine("transectio limit full");
                }
            }
            else
            {
                Console.WriteLine("Sorry widthraw not possible");

            }

        }
    }

}






