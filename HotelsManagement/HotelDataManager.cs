using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelsManagement;
using System.Xml.Serialization;
using System.IO;

namespace HotelsManagement
{
    public class HotelDataManager
    {
        public List<Hotel> hotels;
        public List<InventoryType> inventory;
        private StreamWriter streamWriter;
        public StreamReader streamReader;
        private XmlSerializer xmlWriter;
        private XmlSerializationReader xmlReader;

        private String defaultPath = @"file.xml";
        private String RoomPath = @"";

        public HotelDataManager()
        {
            //Create the default list of hotels
            hotels = new List<Hotel>();
            inventory = new List<InventoryType>();
        }

        public void generateHotels()
        {
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

            List<double> ratingValues = new List<double>();
            ratingValues.Add(1.5);
            ratingValues.Add(2);
            ratingValues.Add(2.5);
            ratingValues.Add(3);
            ratingValues.Add(3.5);
            ratingValues.Add(4);
            ratingValues.Add(4.5);
            ratingValues.Add(5);

            for (int i = 0; i < amountOfHotels; i++)
            {

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

                Hotel hotel = new Hotel(i, hotelNames[i], hotelAddresses[i], rating);
                hotel.Features = new Features(
                    (r.NextDouble() < 0.5) ? true : false,
                    (r.NextDouble() < 0.5) ? true : false,
                    (r.NextDouble() < 0.5) ? true : false,
                    (r.NextDouble() < 0.5) ? true : false);
                hotel.Features.Distances.Airport = Math.Round(r.NextDouble() * 5, 2);
                hotel.Features.Distances.Beach = Math.Round(r.NextDouble() * 5, 2);
                hotel.Features.Distances.Shopping = Math.Round(r.NextDouble() * 5, 2);

                Room KB = new Room(Room.BedType.KB, RoundOff(104 * rating, 10), 5);
                hotel.RoomList.Add(KB);

                Room QB = new Room(Room.BedType.QB, RoundOff(122 * rating, 10), 4);
                hotel.RoomList.Add(QB);

                Room DB = new Room(Room.BedType.DB, RoundOff(123 * rating, 10), 2);
                hotel.RoomList.Add(DB);

                Room BS = new Room(Room.BedType.BS, RoundOff(136 * rating, 10), 6);
                hotel.RoomList.Add(BS);

                this.hotels.Add(hotel);
            }
        }

        public String generateRoomsInventory(String hotels_filePath, String inventories_filePath)
        {

            if (hotels_filePath == null) return "Failed!";
            if (inventories_filePath == null) return "Failed!";

            //Deserialize the xml
            String result = "";
            List<Hotel> hotels = new List<Hotel>();
            hotels = this.readFromXML(out result, hotels, hotels_filePath);
            this.streamReader.Close();

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
                            this.inventory.Add(inventory);
                        }

                    }

                }

                //Create the xml file
                this.writeToXML(out result, this.inventory, inventories_filePath);

            }

            return result;
        }

        public String generateHotelListItems(String roomtypes_filePath, String hotels_filePath, String new_hotels_filePath)
        {
            //Deserialize the xml
            String result = "";
            List<RoomType> roomtype_list = new List<RoomType>();
            roomtype_list = this.readFromXML(out result, roomtype_list, roomtypes_filePath);
            this.streamReader.Close();

            //System.Console.WriteLine("RoomList: " + this.roomtype_list);

            //if (this.roomtype_list != null)
            //foreach (RoomType roomtype in this.roomtype_list)
            // {
            //    System.Console.WriteLine(roomtype.name);
            // }

            List<Hotel> hotel_list = new List<Hotel>();
            hotel_list = this.readFromXML(out result, hotel_list, hotels_filePath);
            this.streamReader.Close();

            //Final Hotel List
            List<HotelListItem> newHotel_list = new List<HotelListItem>();
            //HotelListItem Item = null;
            Random r = new Random();

            for (int h = 0; h < hotel_list.Count; h++)
            {
                //Grab the hotel
                Hotel hotel = hotel_list[h];


                //System.Console.Out.WriteLine(rating);

                //Create the list item
                HotelListItem Item = new HotelListItem(hotel.ID, hotel.Name, hotel.Rating);

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
                newHotel_list.Add(Item);
            }

            //Serialize
            this.writeToXML(out result, newHotel_list, new_hotels_filePath);

            return result;
        }

        public void writeToXML<T>(out String result, List<T> list, String path = null)
        {
            if (path == null)
            {
                this.defaultPath = list.GetType() + "_file.xml";
                path = this.defaultPath;
            }

            //Console.WriteLine(path);

            try {

                if (list != null)
                {
                    //Cast the ref list to hotels 
                    if (typeof(T) == typeof(Hotel)) this.hotels = list.Cast<Hotel>().ToList();

                    //Cast the ref list to inventories
                    if (typeof(T) == typeof(InventoryType)) this.inventory = list.Cast<InventoryType>().ToList();

                    this.streamWriter = new StreamWriter(path);
                    this.xmlWriter = new XmlSerializer(list.GetType());
                    this.xmlWriter.Serialize(this.streamWriter, list);
                    this.streamWriter.Close();
                    result = "File write operation was successful!";

                }
                else
                {
                    result = "File read operation failed: The list was null!";
                }
            }
            catch(Exception error)
            {
                result = "File write operation failed: " + error;
            }
        }

        public List<T> readFromXML<T>(out String result, List<T> list, String filePath = null)
        {
            try
            {
                if (filePath == null) filePath = this.defaultPath;

                this.streamReader = new StreamReader(filePath);
                this.xmlWriter = new XmlSerializer(list.GetType());

                //System.Console.WriteLine("List Type: " + list.GetType());
                       
                result = "File read operation was successful!";
               
                //xmlStream.Close();
                return (List<T>)this.xmlWriter.Deserialize(this.streamReader);
            }
            catch(Exception error)
            {
                result = "File read operation failed: " + error;
            }

            return null;
           
        }

        public double RoundOff(double number, int interval)
        {
            double remainder = number % interval;
            number += (remainder < interval / 2) ? -remainder : (interval - remainder);
            return number;
        }

        bool ReserveRoom(ReservationType reservation)
        {
            return false;
        }
    }
}
