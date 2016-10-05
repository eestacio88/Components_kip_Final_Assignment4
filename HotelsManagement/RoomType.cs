using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{
    public class RoomType
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public RoomType()
        { }

        public RoomType(String name, int ID)
        {
            this.Name = name;
            this.ID = ID;
        }

    }
}
