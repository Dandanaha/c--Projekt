using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKatalogue.model
{
    public class CollectionItem
    {
        private List<Book> _bookList = new List<Book>();
        public List<Book> BookList
        {
            get { return _bookList; }
            set { _bookList = value; }
        }

        private string _name = "New Collection";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _bookCount = 0;
        public int BookCount
        {
            get { return _bookCount; }
            set { _bookCount = value; }
        }

        public CollectionItem() { }

        public void AddBook(Book book)
        {
            _bookList.Add(book);
            _bookCount = _bookList.Count;
        }

        //TODO:
        public void RemoveBook(string name)
        {
            Book book = _bookList.Find(x => x.Title == name);
            if(book != null)
            {
                _bookList.Remove(book);
                _bookCount = _bookList.Count;
            }                
        }
    }
}
