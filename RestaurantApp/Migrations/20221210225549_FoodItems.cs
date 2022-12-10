using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantApp.Migrations
{
    public partial class FoodItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FoodItems",
                newName: "FoodId");

            migrationBuilder.RenameColumn(
                name: "Ammount",
                table: "Bills",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bills",
                newName: "BillId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodItems",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FoodItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "FoodItems",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Bills",
                newName: "Ammount");

            migrationBuilder.RenameColumn(
                name: "BillId",
                table: "Bills",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FoodItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    TableNumber = table.Column<byte>(type: "tinyint", nullable: false),
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberOfPersons = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.TableNumber);
                    table.ForeignKey(
                        name: "FK_Customers_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BillId",
                table: "Customers",
                column: "BillId");
        }
    }
}
