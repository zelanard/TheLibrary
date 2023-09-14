using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLibrary.Model;
using TheQueue.View;

namespace TheLibrary.Controller
{
    /// <summary>
    /// the controller contorlls the application.
    /// </summary>
    public static class Controller
    {
        /// <summary>
        /// Open the library.
        /// </summary>
        public static void Open()
        {
            Stack<Book> books = new Stack<Book>();
            Library library = new Library();
            while (true)
            {
                Display.MainMenu();
                switch (Display.Input())
                {
                    case 1:
                        //Open the menu to lend books.
                        while (true)
                        {
                            Display.BookInventoryMenu(library.Books);
                            int ChosenBook = Display.Input();
                            //if the chosen book is not exit, borrow the chosen book.
                            if (ChosenBook != library.Books.Count + 1)
                            {
                                BorrowBook(books, library, ChosenBook);
                            }
                            else
                            {
                                //cloes the menu to lend books.
                                break;
                            }
                        }
                        break;
                    
                    case 2:
                        //Print the patrons borrowed books.
                        foreach (Book book in books)
                        {
                            Display.Print(book.ToString());
                        }
                        break;

                    case 3:
                        //Return books to the library.
                        ReturnBooks(books, library);
                        break;

                    case 4:
                        //Exit the application
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                Display.Await();
            }
        }
        
        /// <summary>
        /// Return the book to the library and set the security byte.
        /// </summary>
        /// <param name="books"></param>
        /// <param name="library"></param>
        private static void ReturnBooks(Stack<Book> books, Library library)
        {
            while (books.Count > 0)
            {
                books.Peek().Security = SecurityStatus.CheckedIn;
                library.Books.Add(books.Pop());
            }
        }

        /// <summary>
        /// Lend the book to the patron and set the security byte.
        /// </summary>
        /// <param name="books"></param>
        /// <param name="library"></param>
        /// <param name="ChosenBook"></param>
        private static void BorrowBook(Stack<Book> books, Library library, int ChosenBook)
        {
            books.Push(library.Books[ChosenBook - 1]);
            library.Books.RemoveAt(ChosenBook - 1);
            books.Peek().Security = SecurityStatus.CheckedOut;
        }
    }
}
