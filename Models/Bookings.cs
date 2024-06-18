using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Ticket_Booking_System.Entities
{
    public class Bookings
    {
        public int BookingID { get; set; }
        public int PassengerID { get; set; }
        public Passenger Passenger { get; set; } = new Passenger();
        public int FlightID { get; set; }
        public Flight Flight { get; set; } = new Flight();
        public string Class { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime BookingDate { get; set; }

    }
}
