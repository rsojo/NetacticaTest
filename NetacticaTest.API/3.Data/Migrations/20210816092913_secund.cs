using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetacticaTest.API.Migrations
{
    public partial class secund : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1L, "COPA airline", "COPA airline" },
                    { 2L, "Avianca airline", "Avianca" }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1L, "First Airport", "El Dorado" },
                    { 2L, "Secund Airport", "Miami International Airport" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AirlineId", "ArrivalAirportId", "ArrivalTime", "Code", "DepartureAirportId", "DepartureTime" },
                values: new object[] { 1L, 1L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0123", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AirlineId", "ArrivalAirportId", "ArrivalTime", "Code", "DepartureAirportId", "DepartureTime" },
                values: new object[] { 2L, 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0124", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "FlightId", "PassagerTypeId" },
                values: new object[,]
                {
                    { 2L, 1L, 1 },
                    { 3L, 1L, 0 },
                    { 1L, 2L, 0 },
                    { 4L, 2L, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
