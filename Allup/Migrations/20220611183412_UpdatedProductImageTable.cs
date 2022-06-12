using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class UpdatedProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductImages");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ProductImages",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ProductImages");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
