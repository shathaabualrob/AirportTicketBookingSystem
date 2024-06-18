using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Ticket_Booking_System.Entities
{
    public class Flight
    {
        public int Id { get; private set; }
        public string Airline { get; private set; } = string.Empty;
        public long FlightNumber { get; private set; }
        public string DepartureCountry { get; set; } = string.Empty;
        public string DestinationCountry { get; set; } = string.Empty;
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string DepartureAirport { get; set; } = string.Empty;
        public string ArrivalAirport { get; set; } = string.Empty;
        public float EconomyPrice { get; set; }
        public float BusinessPrice { get; set; }
        public float FirstClassPrice { get; set; }
        public int AvailableSeats { get; private set; }
    }
}
