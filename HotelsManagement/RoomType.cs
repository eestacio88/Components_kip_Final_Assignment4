using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{
    public class RoomType
    {
        public String id { get; set; }
        public String name { get; set; }

        public RoomType(String name, String ID)
        {
            this.name = name;
            this.id = ID;
        }

        public RoomType()
        { }
    }
}
