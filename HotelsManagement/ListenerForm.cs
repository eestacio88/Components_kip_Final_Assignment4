using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelsManagement
{
    public partial class ListenerForm : Form, IObserver
    {
        public ListenerForm()
        {
            InitializeComponent();
        }

        public string GetHotelId()
        {
            return "";
        }

        public void update(ReservationType reserv)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
