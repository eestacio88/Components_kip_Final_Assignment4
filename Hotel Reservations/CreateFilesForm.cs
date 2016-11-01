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
        public List<InventoryType> room_inventories;

        public String hotels_filePath = "../../file_hotels.xml";
        public String new_hotels_filePath = "../../file_new_hotels.xml";
        public String inventories_filePath = "../../file_roominventory.xml";
        public String roomtypes_filePath = "../../roomtypes.xml";
        public String reservations_filePath = "../../file_reservations.xml";

        String xslt_path = "../../file_newHotel.xslt";
        const string xsl_html_file_path = "../../file_new_hotels.html";


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
            //Load the new hotels xml
            String result = "";

            //Load the hotels (Used for cost)
            this.hotelManager.hotels = new List<Hotel>();
            this.hotelManager.hotels = this.hotelManager.readFromXML(out result, this.hotelManager.hotels, hotels_filePath);

            //Load the new hotels
            this.hotelManager.new_hotels = new List<HotelListItem>();
            this.hotelManager.new_hotels = this.hotelManager.readFromXML(out result, this.hotelManager.new_hotels, new_hotels_filePath);

            //Load the room inventory
            this.hotelManager.inventory = new List<InventoryType>();
            this.hotelManager.inventory = this.hotelManager.readFromXML(out result, this.hotelManager.inventory, inventories_filePath);

            //Load any reservations
            //this.hotelManager.reservations = new List<InventoryType>();
            //this.hotelManager.reservations = this.hotelManager.readFromXML(out result, this.hotelManager.reservations, inventories_filePath);
           
            lblStatus.Text = result;
        }

        private String reserveRoom(String hotelId, String date, int numOfDays, String customerId, String bedType)
        {
            return reserveRoom(int.Parse(hotelId), date, numOfDays, customerId, bedType);
        }

        private String reserveRoom(int hotelId, String date, int numOfDays, String customerId, String bedType)
        {
            //Reservation result output
            String result = "";

            try
            {
                //Declare the result and bed type as null
                Room.BedType type = Room.BedType.NULL;
                ReservationResultType res_result = ReservationResultType.NULL;

                //Create the reservation object
                ReservationType reservation = new ReservationType();
 
                //Setup the bed type
                if (bedType != null)
                {
                    switch (bedType)
                    {
                        case "KB": type = Room.BedType.KB; break;
                        case "QB": type = Room.BedType.QB; break;
                        case "BS": type = Room.BedType.BS; break;
                        case "DB": type = Room.BedType.DB; break;
                        default: type = Room.BedType.NULL; break;
                    }
                }

                //Set the reservation properties
                reservation.hotelId = hotelId;
                reservation.numDays = numOfDays;
                reservation.roomType = type;
                reservation.startDate = date;
                reservation.customerId = customerId;

                //Check for any unknown room types
                if (bedType == null || type == Room.BedType.NULL)
                {
                    res_result = ReservationResultType.UnknownRoomType;
                    result = res_result.ToString();        
                }

                //Check if a hotel exists
                HotelListItem hotel = this.hotelManager.new_hotels.Find(x => x.ID == hotelId);

                if (hotel == null)
                {
                    res_result = ReservationResultType.UnknownHotelId;
                    result = res_result.ToString();

                    //Add to the reservations list
                    this.hotelManager.reservations.Add(reservation);
                }

                //Check for valid dates in inventory from the incoming reservation
                List<String> dateList_1 = this.hotelManager.CreateDateList(date, numOfDays);

                foreach (String date1 in dateList_1)
                {
                    InventoryType inventory = this.hotelManager.inventory.Find(x => x.Date == date1);

                    if (inventory == null)
                    {                      
                        //Invalid date so the room is not available
                        res_result = ReservationResultType.RoomNotAvailable;
                        result = res_result.ToString();
                    }
                }

                //Set the reservation result
                reservation.result = res_result;

                //Loop through the room inventories
                foreach (InventoryType item in this.hotelManager.inventory)
                {
                    //Find the hotels that matches the id in the inventory list
                    hotel = this.hotelManager.new_hotels.Find(x => x.ID == item.HotelId);

                    if (hotel != null)
                    {
                        //Check to see if the incoming hotel id and incoming date are valid
                        if (hotel.ID == hotelId && item.Date == date)
                        {       
                            //Check the current reservation result
                            if (res_result == ReservationResultType.NULL)
                            {
                                this.hotelManager.ReserveRoom(reservation);

                                //The reservation was a success
                                if (reservation.result == ReservationResultType.Success)
                                {
                                    //Set the id
                                    reservation.reservationId = (this.hotelManager.reservations.Count + 1) + "";

                                    //Get the costs
                                    Hotel costHotel = this.hotelManager.hotels.Find(x => x.ID == reservation.hotelId);
                                    if (costHotel != null)
                                    {
                                        //Grab the room lists and appropriate room type from the hotel
                                        List<Room> costRoomList = costHotel.RoomList;
                                        Room costRoom = costRoomList.Find(x => x.BedSize == reservation.roomType);
                                        
                                        if (costRoom != null)
                                        {
                                            //Multiply rate by days
                                            reservation.cost = costRoom.DailyRate * reservation.numDays;
                                        }
                                    }
                                }
                            }
                            result = reservation.result.ToString();

                            //Add to the reservations list
                            this.hotelManager.reservations.Add(reservation);

                            System.Console.Out.WriteLine("RESULT: " + result);
                            return result;
                        }

                    }
                }

            }
            catch (Exception e)
            {
                lblStatus.Text = "Operation - " + e.Message;
            }

            lblStatus.Text = "Operation - Success";
            System.Console.Out.WriteLine("RESULT: " + result);
            return result;
        }

        private void btnCreateNewHotel_Click(object sender, EventArgs e)
        {
            // hotelID, date, number of days, customer ID, room type          
            reserveRoom("0001", "20160905", 1, "00001", "KB");
            reserveRoom("0001", "20160905", 4, "00002", "KB");
            reserveRoom("0001", "20160905", 5, "00003", "KB");
            reserveRoom("0001", "20160907", 3, "00004", "KB");
            reserveRoom("0001", "20160909", 4, "00005", "KB");
            reserveRoom("0001", "20160906", 5, "00006", "KB"); // fails - room not available
            reserveRoom("0001", "20160905", 1, "00007", "QB");
            reserveRoom("0001", "20160905", 1, "00008", "KB"); // fails- room not available
            reserveRoom("0001", "20160905", 4, "00009", "QB");
            reserveRoom("0001", "20170905", 1, "00010", "KB"); // fails- room not available
            reserveRoom("0005", "20160915", 5, "00011", "QB");
            reserveRoom("0005", "20160925", 10, "00012", "QB"); // fails- room not available
            reserveRoom("0005", "20160907", 3, "00013", "QB");
            reserveRoom("0005", "20160909", 3, "00014", "KB");
            reserveRoom("0005", "20160905", 1, "00015", "AB"); // fails- unknown room type
            reserveRoom("000999", "20160905", 1, "00016", "DB"); // fails- unknown hotel ID

            String result = "";
            this.hotelManager.writeToXML(out result, this.hotelManager.reservations, reservations_filePath);
            lblStatus.Text = "Operation - " + result;
        }

        private void loadHotelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String result = this.hotelManager.generateHotelListItems(roomtypes_filePath, hotels_filePath, new_hotels_filePath);
            lblStatus.Text = "Operation - " + result;
        }

        private void createNewHotelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XslCompiledTransform xslt = new XslCompiledTransform();
                xslt.Load(xslt_path);
                xslt.Transform(new_hotels_filePath, xsl_html_file_path);

                BrowserForm frm = new BrowserForm();
                frm.URL = xsl_html_file_path;
                frm.ShowDialog();

                lblStatus.Text = "Operation - Successful!";
            }
            catch (Exception err)
            {
                lblStatus.Text = "Operation - " + err.Message;
                System.Console.Out.WriteLine(err.Message);
            }
        }
    }
}
