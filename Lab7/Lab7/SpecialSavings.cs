using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class SpecialSavings : Account
    {

        private int transectionCount = 0;

        int minimalNo = 3;
        public int TransectionCount
        {
            get { return transectionCount; }
            set { transectionCount = value; }
        }
        public SpecialSavings()
        {

        }
        public SpecialSavings(string name, string id, double balance) : base(name, id, balance)
        {

        }


        public override void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("After deposit " + amount + " balance is " + Balance);
        }

        public override void Withdraw(double amount)
        {

            if (transectionCount <= minimalNo)
            {

                if (Balance - amount >= Balance * 0.2)
                {
                    Balance = Balance - amount;
                    Console.WriteLine("Your balance is : " + Balance);
                    transectionCount++;
                }
                else
                {
                    Console.WriteLine("Sorry widthraw not possible, minimum 20% balance reqiured after withdraw");
                }

            }
            else
            {

                Console.WriteLine("Insuficient fund");


            }
        }

    }
}

