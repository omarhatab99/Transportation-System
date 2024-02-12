using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class modifySomeProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableSeats",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "AvailableSeats",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "License",
                table: "Drivers",
                type: "int",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 14);

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_License",
                table: "Drivers",
                column: "License",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Drivers_License",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "AvailableSeats",
                table: "Trips");

            migrationBuilder.AddColumn<int>(
                name: "AvailableSeats",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "License",
                table: "Drivers",
                type: "decimal(18,2)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 14);
        }
    }
}
