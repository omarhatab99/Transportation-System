using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class modifySomeProperties2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "License",
                table: "Drivers",
                type: "bigint",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 14);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "License",
                table: "Drivers",
                type: "int",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 14);
        }
    }
}
