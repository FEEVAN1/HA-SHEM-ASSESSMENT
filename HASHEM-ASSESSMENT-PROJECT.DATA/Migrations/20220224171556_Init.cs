using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HASHEM_ASSESSMENT_PROJECT.DATA.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GasStationComplaints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplyDate = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    SupplyLocation = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: false),
                    SupplyInvoiceUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TotalQuantityRecieved = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasStationComplaints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleOwnersComplaints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleOwnershipProofUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelPurhcaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GasStationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseReceipt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOutlet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LitresPurchase = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleOwnersComplaints", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GasStationComplaints");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VehicleOwnersComplaints");
        }
    }
}
