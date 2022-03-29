using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eProdaja.Migrations
{
    public partial class PreglediNarudzbe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PregledNarudzbi",
                columns: table => new
                {
                    PregledNarudzbiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupacId = table.Column<int>(type: "int", nullable: true),
                    PorizvodProizvodId = table.Column<int>(type: "int", nullable: true),
                    ProizvodId = table.Column<int>(type: "int", nullable: true),
                    DatumOD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumDO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrojNarudzbe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IznosNarudzbe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinimalniIznosNarudzbe = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PregledNarudzbi", x => x.PregledNarudzbiId);
                    table.ForeignKey(
                        name: "FK_PregledNarudzbi_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PregledNarudzbi_Proizvodi_PorizvodProizvodId",
                        column: x => x.PorizvodProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Narudzbe",
                columns: new[] { "NarudzbaID", "BrojNarudzbe", "Datum", "KupacID", "Otkazano", "Status" },
                values: new object[,]
                {
                    { 1, "aaa", new DateTime(2022, 3, 29, 18, 56, 4, 19, DateTimeKind.Local).AddTicks(2698), 1, false, true },
                    { 2, "bbb", new DateTime(2022, 3, 29, 18, 56, 4, 26, DateTimeKind.Local).AddTicks(1051), 1, false, true },
                    { 3, "ccc", new DateTime(2022, 3, 29, 18, 56, 4, 26, DateTimeKind.Local).AddTicks(1326), 2, false, true },
                    { 4, "ddd", new DateTime(2022, 3, 29, 18, 56, 4, 26, DateTimeKind.Local).AddTicks(1392), 2, false, true }
                });

            migrationBuilder.InsertData(
                table: "PregledNarudzbi",
                columns: new[] { "PregledNarudzbiId", "BrojNarudzbe", "DatumDO", "DatumOD", "IznosNarudzbe", "KupacId", "MinimalniIznosNarudzbe", "PorizvodProizvodId", "ProizvodId" },
                values: new object[,]
                {
                    { 1, "aaa", new DateTime(2022, 3, 29, 18, 56, 4, 27, DateTimeKind.Local).AddTicks(6255), new DateTime(2022, 3, 19, 18, 56, 4, 27, DateTimeKind.Local).AddTicks(6766), 1000m, 1, 10m, null, 1 },
                    { 2, "bbb", new DateTime(2022, 3, 29, 18, 56, 4, 27, DateTimeKind.Local).AddTicks(9305), new DateTime(2022, 3, 14, 18, 56, 4, 27, DateTimeKind.Local).AddTicks(9337), 1000m, 2, 10m, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Izlazi",
                columns: new[] { "IzlazID", "BrojRacuna", "Datum", "IznosBezPDV", "IznosSaPDV", "KorisnikID", "NarudzbaID", "SkladisteID", "Zakljucen" },
                values: new object[] { 1, "aaa", new DateTime(2022, 3, 29, 18, 56, 4, 26, DateTimeKind.Local).AddTicks(9018), 560m, 580m, 1, 1, 1, false });

            migrationBuilder.InsertData(
                table: "NarudzbaStavke",
                columns: new[] { "NarudzbaStavkaID", "Kolicina", "NarudzbaID", "ProizvodID" },
                values: new object[,]
                {
                    { 1, 10, 1, 1 },
                    { 2, 10, 2, 1 },
                    { 3, 19, 3, 2 },
                    { 4, 19, 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PregledNarudzbi_KupacId",
                table: "PregledNarudzbi",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_PregledNarudzbi_PorizvodProizvodId",
                table: "PregledNarudzbi",
                column: "PorizvodProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PregledNarudzbi");

            migrationBuilder.DeleteData(
                table: "Izlazi",
                keyColumn: "IzlazID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4);
        }
    }
}
