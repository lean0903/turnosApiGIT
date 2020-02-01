using Microsoft.EntityFrameworkCore.Migrations;

namespace apiTurnos.Migrations
{
    public partial class fixturnov5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_jornadasServicios_jornadaId",
                table: "jornadasServicios",
                column: "jornadaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_jornadasServicios_jornadaId",
                table: "jornadasServicios");
        }
    }
}
