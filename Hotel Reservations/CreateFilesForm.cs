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

        public CreateFilesForm()
        {
            InitializeComponent();

            //Create the manager
            this.hotelManager = new HotelDataManager();

            //Create some hotels
            const int amountOfHotels = 10;
            String[] hotelNames = new String[amountOfHotels] {
                "Bronze Nebula Hotel & Spa",
                "Lord's Valley Hotel",
                "Golden Grove Resort",
                "Viridian Vertex Hotel",
                "Mellow Bay Resorts",
                "Scarlet Raven Hotel",
                "Emerald Hotel",
                "Ocean Hotel",
                "Seven Seas Resort",
                "Stratosphere Hotel & Spa"
            };

            String[] hotelAddresses = new String[amountOfHotels] {
                "1600 N Lakeline Blvd #1726, Cedar Park, TX, 78613",
                "11 Logan Pl, Mastic, NY, 11950",
                "3583 Bayview Ave, Saint James City, FL, 33956",
                "168 Jones Chapel Shiloh Rd, Danielsville, GA, 30633",
                "3 Elm Pvt Dr, Somerville, AL, 35670",
                "1205 S Hitchite Ave, Wewoka, OK, 74884",
                "1015 W Sam Houston St, Pharr, TX, 78557",
                "270 Cherokee Dr, Saulsbury, TN, 38067",
                "163 Ems C31 Ln, Warsaw, IN, 46582",
                "8454 Wright St, Fort Campbell, KY, 42223"
            };

            Random r = new Random();

            for (int i = 0; i < amountOfHotels; i++)
            {
                Hotel hotel = new Hotel(i, hotelNames[i], hotelAddresses[i]);
                hotel.Features = new Features(
                    (r.NextDouble() < 0.5) ? true : false,
                    (r.NextDouble() < 0.5) ? true : false,
                    (r.NextDouble() < 0.5) ? true : false,
                    (r.NextDouble() < 0.5) ? true : false);
                hotel.Features.Distances.Airport = Math.Round(r.NextDouble() * 5, 2);
                hotel.Features.Distances.Beach = Math.Round(r.NextDouble() * 5, 2);
                hotel.Features.Distances.Shopping = Math.Round(r.NextDouble() * 5, 2);

                Room KB = new Room(Room.BedType.KB, (r.Next(50, 700) ), 5);
                hotel.RoomList.Add(KB);

                Room QB = new Room(Room.BedType.QB, (r.Next(50, 700) ), 4);
                hotel.RoomList.Add(QB);

                Room DB = new Room(Room.BedType.DB, r.Next(50, 700) , 2);
                hotel.RoomList.Add(DB);

                Room BS = new Room(Room.BedType.BS, r.Next(50, 700) , 6);
                hotel.RoomList.Add(BS);

                this.hotelManager.hotels.Add(hotel);

            }
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

            //Deserialize the xml
            String result = "";
            List<Hotel> hotels = new List<Hotel>();
            hotels = this.hotelManager.readFromXML(out result, hotels, hotels_filePath);
            this.hotelManager.streamReader.Close();

            List<InventoryType> inventories = new List<InventoryType>();
            //inventories = this.hotelManager.readFromXML(out result, inventories);

            int year = 2016;
            int month = 9;

            if (hotels != null)
            {
                for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
                {
                    DateTime dt = new DateTime(year, month, i);
                    // Console.WriteLine(dt.ToShortDateString());

                    //Loop through bed sizes
                    for (int rb = 0; rb < Enum.GetNames(typeof(Room.BedType)).Length; rb++)
                    {
                        InventoryType inventory = null;
                        Random r = new Random();

                        for (int h = 0; h < hotels.Count; h++)
                        {
                            //Grab the hotel
                            Hotel hotel = hotels[h];

                            //Create the inventory instance
                            inventory = new InventoryType(hotel.ID, dt);
                            inventory.Quantity = r.Next(0, 6);

                            //Cast int to enum
                            inventory.RoomType = (Room.BedType)rb;

                            //Add inventory instance to manager inventory list                        
                            this.hotelManager.inventory.Add(inventory);
                        }

                    }

                }

                //Create the xml file
                this.hotelManager.writeToXML(out result, this.hotelManager.inventory, inventories_filePath);

            }

            /*
            System.Console.WriteLine("READING FILE!");
            System.Console.WriteLine( hotels.Capacity);
            for (int i = 0; i < hotels.Count; i++)
            {
                Console.WriteLine(hotels[i].Name);
            }
            */
           
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
            //Deserialize the xml
            String result = "";
            this.roomtype_list = new List<RoomType>();
            this.roomtype_list = this.hotelManager.readFromXML(out result, this.roomtype_list, roomtypes_filePath);
            this.hotelManager.streamReader.Close();

            //System.Console.WriteLine("RoomList: " + this.roomtype_list);

            //if (this.roomtype_list != null)
                //foreach (RoomType roomtype in this.roomtype_list)
               // {
                //    System.Console.WriteLine(roomtype.name);
               // }

            this.hotel_list = new List<Hotel>();
            this.hotel_list = this.hotelManager.readFromXML(out result, this.hotel_list, hotels_filePath);
            this.hotelManager.streamReader.Close();

            //Final Hotel List
            this.newHotel_list = new List<HotelListItem>();
            //HotelListItem Item = null;
            Random r = new Random();

            List<double> ratingValues = new List<double>();
            ratingValues.Add(1.5);
            ratingValues.Add(2);
            ratingValues.Add(2.5);
            ratingValues.Add(3);
            ratingValues.Add(3.5);
            ratingValues.Add(4);
            ratingValues.Add(4.5);
            ratingValues.Add(5);

            for (int h = 0; h < hotel_list.Count; h++)
            {
                //Grab the hotel
                Hotel hotel = hotel_list[h];
                double rating = 1.5;

                if (ratingValues.Count > 0)
                {
                    int randomIndex = r.Next(ratingValues.Count);
                    rating = ratingValues[randomIndex];
                    ratingValues.Remove(rating);
                }
                else
                {
                    rating = r.Next(1, 5);
                    rating = (r.NextDouble() < 0.5) ? rating + 0.5 : rating;
                    if (rating <= 1) rating = 1.5;
                    if (rating > 5) rating = 5;
                }

                //System.Console.Out.WriteLine(rating);

                //Create the list item
                HotelListItem Item = new HotelListItem(hotel.ID, hotel.Name, rating);

                //Create its room
                listItemRoom room;

                //Iterate through the loaded hotel file's rooms
                for (int a = 0; a < hotel.RoomList.Count; a++)
                {
                    //Get the the rooms
                    Room tempRoom = hotel.RoomList[a];
                    room = new listItemRoom(listItemRoom.getNameFromBedSize(tempRoom.BedSize.ToString()), tempRoom.DailyRate, tempRoom.Capacity);
                    //System.Console.WriteLine(room.Type);

                    //Add to the new hotel item's room list
                    Item.RoomTypes.Add(room);
                }


                //Add the new hotel item to the final list
                this.newHotel_list.Add(Item);              
            }

            //Serialize
            this.hotelManager.writeToXML(out result, this.newHotel_list, new_hotels_filePath);
            lblStatus.Text = "Operation - " + result;
        }

        String xslt_path = "file_newHotel.xslt";
        const string xsl_html_file_path = "file_new_hotels.html";

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
