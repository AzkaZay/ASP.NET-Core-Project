using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatisserieCD.Migrations
{
    /// <inheritdoc />
    public partial class AddProductId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "UnitPrice");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PreparationLeadTimeHours",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PreparationLeadTimeHours",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Products",
                newName: "Price");
        }
    }
}
