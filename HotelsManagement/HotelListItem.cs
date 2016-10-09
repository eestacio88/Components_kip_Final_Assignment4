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
        public List<listItemRoom> RoomTypes;

        public HotelListItem() { }

        public HotelListItem(int id, String name, Double rating)
        {
            this.ID = id;
            this.Name = name;
            this.Rating = rating;
            this.RoomTypes = new List<listItemRoom>();
        }

    }
}
