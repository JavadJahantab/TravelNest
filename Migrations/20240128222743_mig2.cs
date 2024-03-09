using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelNest.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalDateTime",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "DepartureDateTime",
                table: "Flights",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "ArrivalAirport",
                table: "Flights",
                newName: "origin");

            migrationBuilder.AlterColumn<string>(
                name: "DepartureAirport",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "destination",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "destination",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "origin",
                table: "Flights",
                newName: "ArrivalAirport");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Flights",
                newName: "DepartureDateTime");

            migrationBuilder.AlterColumn<string>(
                name: "DepartureAirport",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalDateTime",
                table: "Flights",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
