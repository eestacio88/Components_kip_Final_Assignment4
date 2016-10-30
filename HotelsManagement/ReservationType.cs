using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{ 
    public class ReservationType
    {
        public int hotelId { get; set; }
        public String startDate { get; set; }
        public int numDays { get; set; }
        public String customerId { get; set; }
        public Room.BedType roomType { get; set; }
        public String reservationId { get; set; }
        public double cost { get; set; }
        public ReservationResultType result;
    }

    public enum ReservationResultType
    {
        Success,
        RoomNotAvailable,
        UnknownHotelId,
        UnknownRoomType,
        NULL
    }

    
}
