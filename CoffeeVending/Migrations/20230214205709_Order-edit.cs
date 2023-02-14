using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeVending.Migrations
{
    /// <inheritdoc />
    public partial class Orderedit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Order",
                newName: "Suger");

            migrationBuilder.AddColumn<bool>(
                name: "Caramelle",
                table: "Order",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Creamer",
                table: "Order",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Decofe",
                table: "Order",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Milk",
                table: "Order",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Caramelle",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Creamer",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Decofe",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Milk",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Suger",
                table: "Order",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Order",
                type: "float",
                nullable: true);
        }
    }
}
