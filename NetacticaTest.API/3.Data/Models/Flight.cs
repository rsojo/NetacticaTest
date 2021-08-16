using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetacticaTest.API.Models
{
    public class Flight
    {
        public Int64 Id { get; set; }
        public Int64 ArrivalAirportId { get; set; }
        public Int64 AirlineId { get; set; }
        public Int64 DepartureAirportId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Code { get; set; }

        //Navigation Property
        public List<Booking> Bookings { get; set; }
        public Airline Airline { get; set; }
        public Airport ArrivalAirport { get; set; }
        public Airport DepartureAirport { get; set; }
    }
}
