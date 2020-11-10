using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Megnathbodh", "Michel", "3453", "RomCom", 3);
            Book b2 = new Book("Podda Nodir Majhi", "Manik Bondhopaddai", "5235", "Horror", 5);
            Book b3 = new Book("Lal Shalu", "Abu Zafer", "6264", "Commedy", 2);
            Library l = new Library("BookHouse", "Kuratoli", 3, new Book[] { b1, b2, b3 });
            l.AddNewBook(new Book("Vindesh", "Abu Zafer", "6264", "Commedy", 2));
            l.DeleteBook(b3);
            l.AddNewBookCopy(b2, 3);
            l.ShowAllBook();
        }
    }
}