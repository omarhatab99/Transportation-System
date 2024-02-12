using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class modifySomeProperties4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "LicensePlate",
                table: "Vehicles",
                type: "bigint",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 8);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "LicensePlate",
                table: "Vehicles",
                type: "decimal(18,2)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 8);
        }
    }
}
