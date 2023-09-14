using System;
using System.Collections.Generic;
using TheLibrary.Model;

namespace TheQueue.View
{
    /// <summary>
    /// Contorls the display.
    /// </summary>
    internal static class Display
    {
        /// <summary>
        /// Output the app header.
        /// </summary>
        public static void Header()
        {
            Console.WriteLine("  _____    _                         _       _     _                                _  _  ");
            Console.WriteLine(" |_   _|  | |_      ___      o O O  | |     (_)   | |__      _ _   __ _      _ _   | || | ");
            Console.WriteLine("   | |    | ' \\    / -_)    o       | |__   | |   | '_ \\    | '_| / _` |    | '_|   \\_, | ");
            Console.WriteLine("   |_|    |_||_|   \\___|   TS__[O]  |____|  |_|   |_.__/    |_|   \\__,_|    |_|     |__/  ");
            Console.WriteLine("_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"| {======|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_|\"\"\"\"\"|_| \"\"\"\"| ");
            Console.WriteLine("\"`-0-0-'\"`-0-0-'\"`-0-0-'./o--000'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-'\"`-0-0-' "); Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Display the main menu.
        /// </summary>
        public static void MainMenu()
        {
            Console.Clear();
            Header();
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("                                  Welcome to the Library!");
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("1. View Library Inventory");
            Console.WriteLine("2. Your Borrowed Books");
            Console.WriteLine("3. Return all Books");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
        }

        /// <summary>
        /// display the book inventory menu.
        /// </summary>
        /// <param name="books"></param>
        public static void BookInventoryMenu(List<Book> books)
        {
            int i = 1;
            Header();
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("                                  Library Inventory");
            Console.WriteLine("=============================================================================================");
            foreach(Book book in books)
            {
                Console.WriteLine($"{i}. {book}");
                i++;
            }
            Console.WriteLine($"{i}. Exit");
            Console.WriteLine();
        }

        /// <summary>
        /// prompt the user for a numeric input.
        /// </summary>
        /// <returns>int</returns>
        public static int Input()
        {
            Console.WriteLine("Enter number to select menu item.");
            while (true)
            {
                try
                {
                    return Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("NaN: PLease enter a number, which must be in the menu!");
                }
            }
        }

        /// <summary>
        /// await for the user to press any key.
        /// </summary>
        internal static void Await()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        /// <summary>
        /// print message to the console.
        /// </summary>
        /// <param name="msg"></param>
        public static void Print(string msg)
        {
            Console.WriteLine($"{msg}");
        }
    }
}
