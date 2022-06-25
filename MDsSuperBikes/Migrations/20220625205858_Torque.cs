using Microsoft.EntityFrameworkCore.Migrations;

namespace MDsSuperBikes.Migrations
{
    public partial class Torque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TopSpeed",
                table: "Bike",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Torque",
                table: "Bike",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopSpeed",
                table: "Bike");

            migrationBuilder.DropColumn(
                name: "Torque",
                table: "Bike");
        }
    }
}
