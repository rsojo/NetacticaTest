using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetacticaTest.API.Models
{
    public class Airport
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation Property
        public List<Flight> DepartureFlights { get; set; }
        public List<Flight> ArrivalFlights { get; set; }
    }
}
