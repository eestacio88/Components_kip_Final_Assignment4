using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{
    class ReservationType
    {
        public String hotelId { get; set; }
        public String startDate { get; set; }
        public int numDays { get; set; }
        public String customerId { get; set; }
        public String roomType { get; set; }
        public String reservationId { get; set; }
        public double cost { get; set; }
        ReservationResultType result;
    }

    enum ReservationResultType
    {
        Success,
        RoomNotAvailable,
        UnknownHotelId,
        UnknownRoomType
    }

    
}
