using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookKatalogue.model
{
    public class Collection
    {
        private List<CollectionItem> _collectionList = new List<CollectionItem>();
        public List<CollectionItem> CollectionList
        {
            get { return _collectionList; }
        }

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

        public CollectionItem GetCollection(string name)
        {
            return _collectionList.Find(x => x.Name == name);
        }

        public void SaveCollection(string fileName)
        {            
            XmlSerializer SerializerObj = new XmlSerializer(typeof(Collection));               
            TextWriter WriteFileStream = new StreamWriter(fileName); // @"C:\" + fileName + ".xml"
            SerializerObj.Serialize(WriteFileStream, this);
            WriteFileStream.Close();
        }

        public Collection LoadCollection(string fileName)
        {
            XmlSerializer SerializerObj = new XmlSerializer(typeof(Collection));
            FileStream ReadFileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read); // @"C:\" + fileName + ".xml"
            Collection LoadedObj = (Collection)SerializerObj.Deserialize(ReadFileStream);
            ReadFileStream.Close();

            _collectionList = LoadedObj.CollectionList;

            return LoadedObj;
        }
    }
}
