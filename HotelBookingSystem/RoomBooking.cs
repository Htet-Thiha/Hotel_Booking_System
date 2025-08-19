using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    class RoomBooking
    {
        public int RoomID { get; set; }
        public int ExtraGuest { get; set; }
        public double RoomPrice { get; set; }
        public double ExtraGuestPrice { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
