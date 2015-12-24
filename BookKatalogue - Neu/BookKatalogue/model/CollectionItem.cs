using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKatalogue.model
{
    class CollectionItem
    {
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
    }
}
