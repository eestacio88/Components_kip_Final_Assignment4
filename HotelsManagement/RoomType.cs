using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{
    public class RoomType
    {
        public int roomID { get; set; }
        public String name { get; set; }

        public RoomType()
        { }

        public RoomType(int roomID, String name)
        {
            this.roomID = roomID;
            this.name = name;

        }

    }
}
