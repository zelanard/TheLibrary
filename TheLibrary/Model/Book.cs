using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLibrary.Model
{
    /// <summary>
    /// <c>Book</c> Models a book.
    /// </summary>
    internal class Book
    {
        private string _title;
        private string _author;
        private string _barcode;
        private SecurityStatus _security;

        #region Constructors
        private Book()
        {
            Title = "";
            Author = "";
            Barcode = "";
            Security = SecurityStatus.CheckedIn;
        }
        private Book(string title) : this()
        {
            Title = title;
        }
        private Book(string title, string author) : this(title)
        {
            Author = author;
        }
        /// <summary>
        /// Constructs a book.
        /// </summary>
        public Book(string title, string author, string barcode) : this(title, author)
        {
            Barcode = barcode;
        }
        #endregion

        #region Properties

        /// <summary>
        /// the books title.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }

            private set
            {
                _title = value;
            }
        }

        /// <summary>
        /// The Authors Name.
        /// </summary>
        public string Author
        {
            get
            {
                return _author;
            }

            private set
            {
                _author = value;
            }
        }

        /// <summary>
        /// The books barcode.
        /// </summary>
        public string Barcode
        {
            get
            {
                return _barcode;
            }

            private set
            {
                _barcode = value;
            }
        }

        /// <summary>
        /// The books security Code.
        /// </summary>
        public SecurityStatus Security
        {
            get
            {
                return _security;
            }

            set
            {
                _security = value;
            }
        }
        #endregion

        //Overrides to string. Returns the books title and author.
        public override string ToString()
        {
            return $"{Title} by {Author}";
        }

    }
    public enum SecurityStatus
    {
        CheckedIn,
        CheckedOut,
        OutOfCirculation, //As this is not a real library, this value is obsolete.
        Discarded //As this is not a real library, this value is obsolete.
    }
}
