using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKatalogue.model
{
    public class Book
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value;  }
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        private string _isbn;
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public Book() { }

    }
}
