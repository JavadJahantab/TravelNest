using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelNest.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomNumber",
                table: "HotelRooms",
                newName: "City");

            migrationBuilder.AlterColumn<bool>(
                name: "IsOccupied",
                table: "HotelRooms",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "HotelRooms",
                newName: "RoomNumber");

            migrationBuilder.AlterColumn<bool>(
                name: "IsOccupied",
                table: "HotelRooms",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }
    }
}
