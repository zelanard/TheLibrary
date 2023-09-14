using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheLibrary.Model
{
    /// <summary>
    /// <c>Library</c> models a library.
    /// </summary>
    internal class Library
    {
        private List<Book> _books;
        
        /// <summary>
        /// Construct the library with all it's books. Use the value generators to do so.
        /// </summary>
        public Library()
        {
            Books = new List<Book>();
            for (int i = 0; i < 25; i++)
            {
                Books.Add(new Book(
                    Generator.GetRandomBookTitle(),
                    Generator.GetRandomName(),
                    Generator.GenerateRandomBarcode(12)
                ));
                Thread.Sleep(1); //random numbers are generated using time. Awaiting a single milisecond ensures that the same book isn't genrated twice in a row.
            }
        }
        /// <summary>
        /// List of books in the library.
        /// </summary>
        internal List<Book> Books
        {
            get
            {
                return _books;
            }

            private set
            {
                _books = value;
            }
        }

        /// <summary>
        /// Get a list of all books in the library.
        /// </summary>
        /// <returns>string</returns>
        public string Inventory()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Book book in Books)
            {
                sb.AppendLine(book.ToString());
            }
            return sb.ToString();
        }
    }
}
