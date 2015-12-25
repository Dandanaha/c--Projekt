using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookKatalogue.model
{
    class Collection
    {
        private List<CollectionItem> _collectionList = new List<CollectionItem>();

        public Collection()
        {
            
        }

        public void AddCollectionItem(CollectionItem item)
        {
            _collectionList.Add(item);
        }

        public void RemoveCollectionItem(CollectionItem item)
        {
            _collectionList.Remove(item);
        }

        public List<CollectionItem> GetCollection()
        {
            return _collectionList;
        }

        public void SaveCollection(string fileName)
        {            
            XmlSerializer SerializerObj = new XmlSerializer(typeof(Collection));            
            TextWriter WriteFileStream = new StreamWriter(@"C:\" + fileName + ".xml");
            SerializerObj.Serialize(WriteFileStream, this);
            WriteFileStream.Close();
        }

        public Collection LoadCollection(string fileName)
        {
            XmlSerializer SerializerObj = new XmlSerializer(typeof(Collection));
            FileStream ReadFileStream = new FileStream(@"C:\" + fileName + ".xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            Collection LoadedObj = (Collection)SerializerObj.Deserialize(ReadFileStream);
            ReadFileStream.Close();

            return LoadedObj;
        }
    }
}
