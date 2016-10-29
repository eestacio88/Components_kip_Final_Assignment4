using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelsManagement
{
    public class InventoryType
    {
        public String Date { get; set; }
        public int HotelId { get; set; }
        public Room.BedType RoomType { get; set; }
        public int Quantity { get; set; }

        public InventoryType() { }

        public InventoryType(int hotelid, DateTime date, Room.BedType bedtype = Room.BedType.DB, int quantity = 0)
        {
            this.Date = date.ToShortDateString();
            this.HotelId = hotelid;
            this.RoomType = bedtype;
            this.Quantity = quantity;
        }

    }
}
