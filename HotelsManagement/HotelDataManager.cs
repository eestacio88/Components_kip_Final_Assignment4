using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelsManagement;
using System.Xml.Serialization;
using System.IO;

namespace HotelsManagement
{
    public class HotelDataManager
    {
        public List<Hotel> hotels;
        public List<InventoryType> inventory;
        private StreamWriter streamWriter;
        private StreamReader streamReader;
        private XmlSerializer xmlWriter;
        private XmlSerializationReader xmlReader;
       
        private String defaultPath = @"file.xml";
        
        public HotelDataManager ()
        {
            //Create the default list of hotels
            hotels = new List<Hotel>();
            inventory = new List<InventoryType>();
        }

        public void writeToXML<T>(List<T> list, String path = null)
        {
            if (path == null)
            {
                this.defaultPath = list.GetType() + "_file.xml";
                path = this.defaultPath;
            }

            //Console.WriteLine(path);

            if (list != null)
            {
                //Cast the ref list to hotels 
                if (typeof(T) == typeof(Hotel)) this.hotels = list.Cast<Hotel>().ToList();

                //Cast the ref list to inventories
                if (typeof(T) == typeof(InventoryType)) this.inventory = list.Cast<InventoryType>().ToList();

                this.streamWriter = new StreamWriter(path);
                this.xmlWriter = new XmlSerializer(list.GetType());
                this.xmlWriter.Serialize(this.streamWriter, list);
                this.streamWriter.Close();
            }
        }

        public List<T> readFromXML<T>(out String result, List<T> list, String filePath = null)
        {
            try
            {
                if (filePath == null) filePath = this.defaultPath;

                StreamReader xmlStream = new StreamReader(filePath);
                this.xmlWriter = new XmlSerializer(list.GetType());           
                result = "File read operation successful!";
                //xmlStream.Close();
                return (List<T>)this.xmlWriter.Deserialize(xmlStream);
            }
            catch(Exception error)
            {
                result = "File read operation failed: " + error;
            }

            return null;
           
        }
    }
}
