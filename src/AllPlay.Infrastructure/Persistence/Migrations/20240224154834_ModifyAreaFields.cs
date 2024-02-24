using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllPlay.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ModifyAreaFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Coordinates",
                schema: "AllPlay",
                table: "Areas",
                newName: "Point");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                schema: "AllPlay",
                table: "Areas",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                schema: "AllPlay",
                table: "Areas",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                schema: "AllPlay",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "Longitude",
                schema: "AllPlay",
                table: "Areas");

            migrationBuilder.RenameColumn(
                name: "Point",
                schema: "AllPlay",
                table: "Areas",
                newName: "Coordinates");
        }
    }
}
