using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oyunlar",
                columns: table => new
                {
                    gameid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gamename = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyunlar", x => x.gameid);
                });

            migrationBuilder.CreateTable(
                name: "Bilgiler",
                columns: table => new
                {
                    gameinfoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gamecategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    Oyunlargameid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilgiler", x => x.gameinfoid);
                    table.ForeignKey(
                        name: "FK_Bilgiler_Oyunlar_Oyunlargameid",
                        column: x => x.Oyunlargameid,
                        principalTable: "Oyunlar",
                        principalColumn: "gameid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilgiler_Oyunlargameid",
                table: "Bilgiler",
                column: "Oyunlargameid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilgiler");

            migrationBuilder.DropTable(
                name: "Oyunlar");
        }
    }
}
