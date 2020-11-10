using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Library
    {
        private string libName;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }

        private string libAddress;

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        private Book[] ListOfBook;

        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }

        public Library()
        {
            ListOfBook = new Book[100];
        }
        public Library(string libName, string libAddress, int totalBook, Book[] listOfBook)
        {
            ListOfBook = new Book[100];
            for (int i = 0; i < totalBook; i++)
            {
                this.ListOfBook[i] = listOfBook[i];
            }
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;

        }
        public void ShowInfo()
        {
            Console.WriteLine("Library Name : " + libName);
            Console.WriteLine("Library Address : " + libAddress);
            Console.WriteLine("Total book : " + totalBook);
        }

        public void ShowAllBook()
        {
            for (int i = 0; i < totalBook; i++)
            {
                ListOfBook[i].ShowInfo();
            }
        }
        public void AddNewBook(Book x)
        {
            ListOfBook[totalBook++] = x;


        }
        public void DeleteBook(Book x)
        {
            bool check = false;
            for (int i = 0; i < totalBook; i++)
            {
                if (this.ListOfBook[i] == x)
                {
                    ListOfBook[i] = ListOfBook[i + 1];
                    ListOfBook[i + 1] = x;
                    check = true;
                }
            }
            if (check) totalBook--;
            else Console.WriteLine("Book Not Found In The List. Please try with write info");
        }

        public void AddNewBookCopy(Book x, int copy)
        {
            bool check = false;
            for (int i = 0; i < totalBook; i++)
            {
                if (this.ListOfBook[i] == x)
                {
                    ListOfBook[i].BookCopy += copy;
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Book Not Found In The List. Please try with write info");

        }



    }
}