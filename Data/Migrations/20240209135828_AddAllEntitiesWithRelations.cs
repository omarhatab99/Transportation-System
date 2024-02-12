using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddAllEntitiesWithRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "TripSequence",
                startValue: 100000000L);

            migrationBuilder.CreateSequence<int>(
                name: "VehicleSequence",
                startValue: 100000000L);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    License = table.Column<decimal>(type: "decimal(18,2)", maxLength: 14, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasBouns = table.Column<bool>(type: "bit", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 10000m),
                    CurrentStation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<decimal>(type: "decimal(18,2)", maxLength: 8, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR VehicleSequence"),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    AvailableSeats = table.Column<int>(type: "int", nullable: false),
                    HasMaintenance = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    HasScheduledMaintenance = table.Column<bool>(type: "bit", nullable: false),
                    CurrentStation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleMaintences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VechieId = table.Column<int>(type: "int", nullable: false),
                    MainteneceDateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MainteneceDateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMainteneceDone = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleMaintences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleMaintences_Vehicles_VechieId",
                        column: x => x.VechieId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR TripSequence"),
                    DepatureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    Fare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trips_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Maintenances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VechieId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    CostOfMaintenece = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maintenances_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maintenances_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maintenances_Vehicles_VechieId",
                        column: x => x.VechieId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    Seats = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Passengers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "Passengers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_Email",
                table: "Drivers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_Phone",
                table: "Drivers",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_Username",
                table: "Drivers",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_DriverId",
                table: "Maintenances",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_TripId",
                table: "Maintenances",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_VechieId",
                table: "Maintenances",
                column: "VechieId");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_Email",
                table: "Passengers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_Gender",
                table: "Passengers",
                column: "Gender");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_Phone",
                table: "Passengers",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PassengerId",
                table: "Reservations",
                column: "PassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_TripId_PassengerId",
                table: "Reservations",
                columns: new[] { "TripId", "PassengerId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleMaintences_VechieId",
                table: "ScheduleMaintences",
                column: "VechieId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleMaintences_VechieId_MainteneceDateStart",
                table: "ScheduleMaintences",
                columns: new[] { "VechieId", "MainteneceDateStart" });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Email",
                table: "Staff",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Username",
                table: "Staff",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stations_Name",
                table: "Stations",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DepatureDate",
                table: "Trips",
                column: "DepatureDate");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_Destination",
                table: "Trips",
                column: "Destination");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DriverId",
                table: "Trips",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DriverId_DepatureDate",
                table: "Trips",
                columns: new[] { "DriverId", "DepatureDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_Source",
                table: "Trips",
                column: "Source");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_VehicleId",
                table: "Trips",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_VehicleId_DepatureDate",
                table: "Trips",
                columns: new[] { "VehicleId", "DepatureDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CategoryId",
                table: "Vehicles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_Model",
                table: "Vehicles",
                column: "Model");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maintenances");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "ScheduleMaintences");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropSequence(
                name: "TripSequence");

            migrationBuilder.DropSequence(
                name: "VehicleSequence");
        }
    }
}
