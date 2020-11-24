using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    abstract class Account
    {
        public string Name { get; set; }

        public string AccId { get; set; }

        public double Balance { get; set; }




        public Account()
        {

        }
        public Account(string Name, string AccId, double Balance)
        {
            this.Name = Name;
            this.AccId = AccId;
            this.Balance = Balance;
        }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);
        virtual public void ShowInfo()
        {
            Console.WriteLine("Account name : " + Name);
            Console.WriteLine("Account Id: " + AccId);
            Console.WriteLine("Balance  : " + Balance);

        }
    }
}
