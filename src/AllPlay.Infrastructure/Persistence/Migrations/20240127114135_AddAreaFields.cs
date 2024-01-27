using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace AllPlay.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAreaFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                schema: "AllPlay",
                table: "Areas",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "AllPlay",
                table: "Areas",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "AllPlay",
                table: "Areas",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Point>(
                name: "Coordinates",
                schema: "AllPlay",
                table: "Areas",
                type: "geography",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "CountryIso",
                schema: "AllPlay",
                table: "Areas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CountryRegion",
                schema: "AllPlay",
                table: "Areas",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormattedAddress",
                schema: "AllPlay",
                table: "Areas",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsOutdoorArea",
                schema: "AllPlay",
                table: "Areas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Polygon>(
                name: "Polygon",
                schema: "AllPlay",
                table: "Areas",
                type: "geography",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                schema: "AllPlay",
                table: "Areas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coordinates",
                schema: "AllPlay",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "CountryIso",
                schema: "AllPlay",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "CountryRegion",
                schema: "AllPlay",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "FormattedAddress",
                schema: "AllPlay",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "IsOutdoorArea",
                schema: "AllPlay",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "Polygon",
                schema: "AllPlay",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                schema: "AllPlay",
                table: "Areas");

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                schema: "AllPlay",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "AllPlay",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "AllPlay",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);
        }
    }
}
