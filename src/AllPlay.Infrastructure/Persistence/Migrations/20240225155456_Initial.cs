using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace AllPlay.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AllPlay");

            migrationBuilder.CreateTable(
                name: "Areas",
                schema: "AllPlay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpenStreetMapId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenStreetMapName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CountryRegion = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CountryIso = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FormattedAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Point = table.Column<Point>(type: "geography", nullable: false),
                    Polygon = table.Column<Polygon>(type: "geography", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    IsOutdoorArea = table.Column<bool>(type: "bit", nullable: true),
                    Leisure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasMultipleSports = table.Column<bool>(type: "bit", nullable: false),
                    Surface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lit = table.Column<bool>(type: "bit", nullable: true),
                    Access = table.Column<bool>(type: "bit", nullable: true),
                    Barrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SportEvents",
                schema: "AllPlay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SportType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportEvents_Areas_AreaId",
                        column: x => x.AreaId,
                        principalSchema: "AllPlay",
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                schema: "AllPlay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SportEventId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_SportEvents_SportEventId",
                        column: x => x.SportEventId,
                        principalSchema: "AllPlay",
                        principalTable: "SportEvents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_Id",
                schema: "AllPlay",
                table: "Areas",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_Id",
                schema: "AllPlay",
                table: "Players",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_SportEventId",
                schema: "AllPlay",
                table: "Players",
                column: "SportEventId");

            migrationBuilder.CreateIndex(
                name: "IX_SportEvents_AreaId",
                schema: "AllPlay",
                table: "SportEvents",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_SportEvents_Id",
                schema: "AllPlay",
                table: "SportEvents",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players",
                schema: "AllPlay");

            migrationBuilder.DropTable(
                name: "SportEvents",
                schema: "AllPlay");

            migrationBuilder.DropTable(
                name: "Areas",
                schema: "AllPlay");
        }
    }
}
