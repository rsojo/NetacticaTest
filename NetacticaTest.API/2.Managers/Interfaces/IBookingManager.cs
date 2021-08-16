using NetacticaTest.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetacticaTest.API._2.Managers.Interfaces
{
    public interface IBookingManager
    {
        Task<Booking> SetItem(Booking booking);
        Task<Booking> GetItem(Int64 id);
        Task<List<Booking>> GetItems(string code);
    }
}
