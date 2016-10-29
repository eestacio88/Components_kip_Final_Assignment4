using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsManagement
{
    public class Features
    {
        public Boolean Laundry { get; set; }
        public Boolean AirConditioning { get; set; }
        public Boolean Shuttle { get; set; }
        public Boolean Breakfast { get; set; }
        public Distances Distances { get; set; }

        public Features() { }

        public Features(Boolean laundry = true, Boolean airconditioning = true, Boolean shuttle = true, Boolean breakfast = true)
        {
            this.Laundry = laundry;
            this.AirConditioning = airconditioning;
            this.Shuttle = shuttle;
            this.Breakfast = breakfast;
            this.Distances = new Distances();
        }

    }
}
