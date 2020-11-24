using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{

    class FixedAccount : Account
    {
        private int currentYear;
        public int CurrentYear
        {
            get { return currentYear; }
            set { currentYear = value; }
        }
        private int tenureYear = 3;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }

        public FixedAccount()
        {

        }
        public FixedAccount(string name, string id, double balance, int currentYear) : base(name, id, balance)

        {
            this.currentYear = currentYear;

        }



        public override void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("After deposit " + amount + " balance is " + Balance);
        }

        public override void Withdraw(double amount)
        {

            if (currentYear >= tenureYear)
            {
                Balance = Balance - amount;
            }
            else
            {
                Console.WriteLine("Account is not matured enough");
            }

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Create Year: " + currentYear);


        }

    }
}

