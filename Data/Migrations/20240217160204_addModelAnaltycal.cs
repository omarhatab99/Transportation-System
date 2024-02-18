using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class addModelAnaltycal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Analatycals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfTrips = table.Column<int>(type: "int", nullable: false),
                    TotalGain = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthlyGain = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analatycals", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analatycals");
        }
    }
}
