using NetacticaTest.API.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetacticaTest.API.Models
{
    public class Booking
    {
        public Int64 Id { get; set; }
        public Int64 FlightId { get; set; }
        public PassagerType PassagerTypeId { get; set; }

        //Navigation Property
        public Flight Flight { get; set; }
    }
}
