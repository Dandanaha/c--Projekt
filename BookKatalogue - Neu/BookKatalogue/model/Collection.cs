using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKatalogue.model
{
    class Collection
    {
        private List<CollectionItem> _collectionList = new List<CollectionItem>();

        public Collection()
        {
            
        }

        public void AddCollection(CollectionItem item)
        {
            _collectionList.Add(item);
        }

        public void RemoveCollection(CollectionItem item)
        {
            _collectionList.Remove(item);
        }
    }
}
