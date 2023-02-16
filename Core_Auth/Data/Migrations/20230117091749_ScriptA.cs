using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_Auth.Data.Migrations
{
    public partial class ScriptA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "plantSizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plantSizes", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "pots",
                columns: table => new
                {
                    potId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    potName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pots", x => x.potId);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    PlantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(nullable: true),
                    StockDate = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    SizeId = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(nullable: true),
                    IsAvaible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.PlantId);
                    table.ForeignKey(
                        name: "FK_Plants_plantSizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "plantSizes",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stockEntries",
                columns: table => new
                {
                    StockEntryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(nullable: false),
                    potId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockEntries", x => x.StockEntryId);
                    table.ForeignKey(
                        name: "FK_stockEntries_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stockEntries_pots_potId",
                        column: x => x.potId,
                        principalTable: "pots",
                        principalColumn: "potId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plants_SizeId",
                table: "Plants",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_stockEntries_PlantId",
                table: "stockEntries",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_stockEntries_potId",
                table: "stockEntries",
                column: "potId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stockEntries");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "pots");

            migrationBuilder.DropTable(
                name: "plantSizes");
        }
    }
}
