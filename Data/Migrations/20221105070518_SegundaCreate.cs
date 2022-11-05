using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyOrder.Data.Migrations
{
    public partial class SegundaCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "varchar (10)", nullable: true),
                    EquipamentModel = table.Column<string>(type: "nvarchar (250)", nullable: true),
                    EquipamentManufacture = table.Column<string>(type: "varchar (100)", nullable: true),
                    RequestId = table.Column<int>(type: "varchar (100)", nullable: false),
                    IsEmergency = table.Column<bool>(type: "varchar (10)", nullable: false),
                    Amount = table.Column<int>(type: "varchar (1)", nullable: false),
                    OSNumber = table.Column<int>(type: "varchar (10)", nullable: false),
                    OrbisTag = table.Column<string>(type: "varchar (20)", nullable: true),
                    Location = table.Column<string>(type: "varchar (40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
