using Microsoft.EntityFrameworkCore;
using NetacticaTest.API.Models;
using NetacticaTest.API.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetacticaTest.API.Services
{
    public class NetacticaTestDbContext : DbContext
    {
        public NetacticaTestDbContext(DbContextOptions opts) : base(opts) { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Airline> Airlines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>()
           .HasOne(p => p.ArrivalAirport)
           .WithMany(b => b.ArrivalFlights)
           .HasForeignKey(p => p.ArrivalAirportId)
           .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Flight>()
           .HasOne(p => p.DepartureAirport)
           .WithMany(b => b.DepartureFlights)
           .HasForeignKey(p => p.DepartureAirportId)
           .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Flight>()
            .HasIndex(u => u.Code)
            .IsUnique();


            modelBuilder.Entity<Airport>().HasData(new Airport { Id = 1, Name = "El Dorado", Description = "First Airport" });
            modelBuilder.Entity<Airport>().HasData(new Airport { Id = 2, Name = "Miami International Airport", Description = "Secund Airport" });

            modelBuilder.Entity<Airline>().HasData(  new Airline { Id = 1, Name = "COPA airline", Description = "COPA airline" });
            modelBuilder.Entity<Airline>().HasData( new Airline { Id = 2, Name = "Avianca", Description = "Avianca airline" });

            modelBuilder.Entity<Flight>().HasData(new Flight { Id = 1, AirlineId = 1, ArrivalAirportId = 2, DepartureAirportId = 1, DepartureTime = new DateTime() , ArrivalTime = new DateTime(), Code = "0123" });
            modelBuilder.Entity<Flight>().HasData(new Flight { Id = 2, AirlineId = 1, ArrivalAirportId = 1, DepartureAirportId = 2, DepartureTime = new DateTime(), ArrivalTime = new DateTime(), Code = "0124" });

            modelBuilder.Entity<Booking>().HasData(new Booking { Id = 1, FlightId = 2, PassagerTypeId = PassagerType.adult });
            modelBuilder.Entity<Booking>().HasData(new Booking { Id = 2, FlightId = 1, PassagerTypeId = PassagerType.kid });
            modelBuilder.Entity<Booking>().HasData(new Booking { Id = 3, FlightId = 1, PassagerTypeId = PassagerType.adult });
            modelBuilder.Entity<Booking>().HasData(new Booking { Id = 4, FlightId = 2, PassagerTypeId = PassagerType.kid });
        }

    }
}
