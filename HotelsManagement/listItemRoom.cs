using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{
    public class listItemRoom
    {
        public String Type { get; set; }
        public int DailyRate { get; set; }
        public int Capacity { get; set; }
        

        public listItemRoom()
        {

        }

        public listItemRoom(String type, int dailyrate, int capacity)
        {
            this.Type = type;
            this.DailyRate = dailyrate;
            this.Capacity = capacity;
        }

        public static String getNameFromBedSize(String bedsize)
        {

            switch(bedsize)
            {
                case "KB":
                    return "Single King Bed";
                case "QB":
                    return "Single Queen Bed";
                case "DB":
                    return "Two Double Beds";
                case "BS":
                    return "One Bedroom Suite";
                default:
                    return "Unknown";
            }
        }
    }
}
