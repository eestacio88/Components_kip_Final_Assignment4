using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{
    public class HotelListItem
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public Double Rating { get; set; }
        public List<RoomType> RoomTypes { get; set; }


        HotelListItem() { }

        HotelListItem(int id, String name, Double rating, List<RoomType> roomtypes)
        {
            this.ID = id;
            this.Name = name;
            this.Rating = rating;
            this.RoomTypes = roomtypes;
        }

    }
}
