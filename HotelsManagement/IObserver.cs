using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{
    public interface IObserver
    {
        string GetHotelId();
        void update(ReservationType reserv);
    }
}
