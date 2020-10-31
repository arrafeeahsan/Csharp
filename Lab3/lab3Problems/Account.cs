using System;
using System.Collections.Generic;
using System.Text;

namespace lab3Problems
{
    class Account
    {
        string accName;
        string accId;
        int balance;



        public Account()
        {
            
        }
        public string AccountName
        {
            
            set { accName = value; }
        }
        public string AccountId
        {

            set { accId = value; }
        }
        public int Balance
        {

            set { balance = value; }
        }
        public void showInfo()
        {
            Console.WriteLine("Acoount name  " + accName);
            Console.WriteLine("Acoount id  " + accId);
            Console.WriteLine("Current balance " + balance);
            Console.WriteLine(" ");


        }
        public void Deposit(int amount)
        {
            balance +=amount;
            Console.WriteLine("after depotist balance is : " + balance);
        }

        public void Withdraw(int amount)
        {
            bool check = true;
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("after withraw balance is : " + balance+"\n");
            }
            else if (amount > balance)
            {
                check = false;

            }


        }

    }
}

