using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo_EF.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fahrzeuge",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    MaximalGeschwindigkeit = table.Column<int>(nullable: false),
                    Preis = table.Column<double>(nullable: false),
                    AktuelleGeschwindigkeit = table.Column<int>(nullable: false),
                    FZustand = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fahrzeuge", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fahrzeuge");
        }
    }
}
