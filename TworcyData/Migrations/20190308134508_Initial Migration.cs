using Microsoft.EntityFrameworkCore.Migrations;

namespace TworcyData.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tworcy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Imie = table.Column<string>(nullable: false),
                    Nazwisko = table.Column<string>(nullable: false),
                    Zdjecie = table.Column<string>(nullable: true),
                    Biogram = table.Column<string>(nullable: true),
                    Bibliografia = table.Column<string>(nullable: true),
                    Nagrody = table.Column<string>(nullable: true),
                    Wystawy = table.Column<string>(nullable: true),
                    Teksty = table.Column<string>(nullable: true),
                    Audio = table.Column<string>(nullable: true),
                    Kontakt = table.Column<string>(nullable: true),
                    Gotowe = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tworcy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zdjecia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TworcaId = table.Column<int>(nullable: false),
                    zdjecieUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zdjecia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zdjecia_Tworcy_TworcaId",
                        column: x => x.TworcaId,
                        principalTable: "Tworcy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zdjecia_TworcaId",
                table: "Zdjecia",
                column: "TworcaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zdjecia");

            migrationBuilder.DropTable(
                name: "Tworcy");
        }
    }
}
