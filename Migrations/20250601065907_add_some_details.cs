using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apartment_Project.Migrations
{
    /// <inheritdoc />
    public partial class add_some_details : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "SomePhoto",
                table: "Apartments",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SomePhoto",
                table: "Apartments");
        }
    }
}
