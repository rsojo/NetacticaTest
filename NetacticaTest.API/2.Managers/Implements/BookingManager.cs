using Microsoft.EntityFrameworkCore;
using NetacticaTest.API._2.Managers.Interfaces;
using NetacticaTest.API.Models;
using NetacticaTest.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetacticaTest.API._2.Managers.Implements
{
    public class BookingManager : IBookingManager
    {
        private readonly NetacticaTestDbContext _context;

        public BookingManager(NetacticaTestDbContext context)
        {
            _context = context;
        }

        public async Task<Booking> GetItem(long id)
        {
            var netacticaTestDbContext = _context.Bookings.Include(b => b.Flight)
                      .ThenInclude(f => f.ArrivalAirport)
                      .Include(a => a.Flight)
                      .ThenInclude(ff => ff.DepartureAirport)
                      .Include(c => c.Flight)
                      .ThenInclude(fff => fff.Airline)
                      .FirstOrDefaultAsync(m => m.Id == id);

            return await netacticaTestDbContext;
        }

        public async Task <List<Booking>> GetItems(string code)
        {
            var netacticaTestDbContext = _context.Bookings
                   .Where(x => x.Flight.Code.Contains(code))
                   .Include(b => b.Flight)
                   .ThenInclude(f => f.ArrivalAirport)
                   .Include(a => a.Flight)
                   .ThenInclude(ff => ff.DepartureAirport)
                   .Include(c => c.Flight)
                   .ThenInclude(fff => fff.Airline)
                   ;
            return await netacticaTestDbContext.ToListAsync();
        }

        public async Task<Booking> SetItem(Booking booking)
        {
            _context.Add(booking);
            await _context.SaveChangesAsync();
            var netacticaTestDbContext = _context.Bookings
                .FirstOrDefaultAsync(m => m.Id == booking.Id);

            return await netacticaTestDbContext;
        }
    }
}
