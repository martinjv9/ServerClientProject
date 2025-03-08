using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StinkyModule.Migrations
{
    /// <inheritdoc />
    public partial class latlng : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Lat",
                table: "City",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Lon",
                table: "City",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lat",
                table: "City");

            migrationBuilder.DropColumn(
                name: "Lon",
                table: "City");
        }
    }
}
