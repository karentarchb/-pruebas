using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1.Migrations
{
    public partial class Recreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_Person",
                columns: table => new
                {
                    IdNumber = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_Person", x => x.IdNumber);
                });

            migrationBuilder.CreateTable(
                name: "t_Result",
                columns: table => new
                {
                    resultID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_Result", x => x.resultID);
                });

            migrationBuilder.CreateTable(
                name: "t_Roulette",
                columns: table => new
                {
                    rouletteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_Roulette", x => x.rouletteID);
                });

            migrationBuilder.CreateTable(
                name: "t_Bet",
                columns: table => new
                {
                    betID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    betAmmount = table.Column<int>(type: "int", nullable: false),
                    betType = table.Column<int>(type: "int", nullable: false),
                    resultID = table.Column<int>(type: "int", nullable: true),
                    rouletteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_Bet", x => x.betID);
                    table.ForeignKey(
                        name: "FK_t_Bet_t_Result_resultID",
                        column: x => x.resultID,
                        principalTable: "t_Result",
                        principalColumn: "resultID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t_Bet_t_Roulette_rouletteID",
                        column: x => x.rouletteID,
                        principalTable: "t_Roulette",
                        principalColumn: "rouletteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_Bet_resultID",
                table: "t_Bet",
                column: "resultID");

            migrationBuilder.CreateIndex(
                name: "IX_t_Bet_rouletteID",
                table: "t_Bet",
                column: "rouletteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_Bet");

            migrationBuilder.DropTable(
                name: "t_Person");

            migrationBuilder.DropTable(
                name: "t_Result");

            migrationBuilder.DropTable(
                name: "t_Roulette");
        }
    }
}
