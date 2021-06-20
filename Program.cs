using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLib;

namespace BookManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Happiness Book Store");
            menu.addNewOption("1.Add a book");
            menu.addNewOption("2.Find a book");
            menu.addNewOption("3.Show book list");
            menu.addNewOption("4.Remove a book");
            menu.addNewOption("5.Exit");

            Cabinet cage = new Cabinet();

            int choice;
            do
            {
                menu.printMenu();
                choice = menu.getChoice();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You are preparing to input a new book");
                        cage.addNewBook();
                        break;
                    case 2:
                        Console.WriteLine("The list book: ");
                        cage.searchBookByID();
                        break;
                    case 3:
                        Console.WriteLine("Show book list: ");
                        cage.printBookList();
                        break;
                    case 4:
                        Console.WriteLine("Remove book: ");
                        cage.removeBook();
                        break;
                    case 5:
                        Console.WriteLine("Bye bye bye, See you later!");
                        break;
                }
            } while (choice != 5);
        }
    }
}
