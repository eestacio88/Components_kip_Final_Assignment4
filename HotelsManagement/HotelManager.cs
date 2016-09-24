using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HotelsManagement
{
    public class Hotel
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public Features Features { get; set; }
        public List<Room> RoomList;

        public Hotel() { }

        public Hotel(int id, String name, String address)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.RoomList = new List<Room>();
        }
    }

    

     
}
