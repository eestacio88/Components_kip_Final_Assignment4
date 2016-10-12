using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelsManagement;
using System.IO;
using System.Xml;
using System.Xml.Xsl;

namespace Hotel_Reservations
{
    public partial class CreateFilesForm : Form
    {
    
        public HotelDataManager hotelManager;
        public List<Hotel> hotel_list;
        public List<HotelListItem> newHotel_list;
        public List<RoomType> roomtype_list;

        public String hotels_filePath = "file_hotels.xml";
        public String new_hotels_filePath = "file_new_hotels.xml";
        public String inventories_filePath = "file_roominventory.xml";
        public String roomtypes_filePath = "roomtypes.xml";

        String xslt_path = "file_newHotel.xslt";
        const string xsl_html_file_path = "file_new_hotels.html";


        public CreateFilesForm()
        {
            InitializeComponent();

            //Create the manager
            this.hotelManager = new HotelDataManager();
            this.hotelManager.generateHotels();
            
        }

        private void mnu_CreateHotel_Click(object sender, EventArgs e)
        {
            //Create the xml file
            String result = "";
            this.hotelManager.writeToXML(out result, this.hotelManager.hotels, hotels_filePath);
            lblStatus.Text = "Hotel File - " + result;
        }

        private void mnu_CreateRoomInventory_Click(object sender, EventArgs e)
        {

            String result = this.hotelManager.generateRoomsInventory(hotels_filePath, inventories_filePath);
            lblStatus.Text = "Inventory File - " + result;

        }

        private void mnu_DisplayHotels_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = hotels_filePath; // "hotels.xml";
            frm.ShowDialog();
        }

        private void mnu_DisplayRoomsInventory_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = inventories_filePath; //"roominventory.xml";
            frm.ShowDialog();
        }

        private void btnLoadHotel_Click(object sender, EventArgs e)
        {

            String result = this.hotelManager.generateHotelListItems(roomtypes_filePath, hotels_filePath, new_hotels_filePath);
            lblStatus.Text = "Operation - " + result;
        }

        private void btnCreateNewHotel_Click(object sender, EventArgs e)
        {
            try {
                XslCompiledTransform xslt = new XslCompiledTransform();
                xslt.Load(xslt_path);
                xslt.Transform(new_hotels_filePath, xsl_html_file_path);

                BrowserForm frm = new BrowserForm();
                frm.URL = xsl_html_file_path;
                frm.ShowDialog();

                lblStatus.Text = "Operation - Successful!";
            }catch(Exception err)
            {
                lblStatus.Text = "Operation - " + err.Message;
                System.Console.Out.WriteLine(err.Message);
            }
        }
    }
}
