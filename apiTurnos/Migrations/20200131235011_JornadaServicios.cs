using Microsoft.EntityFrameworkCore.Migrations;

namespace apiTurnos.Migrations
{
    public partial class JornadaServicios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jornadasServicios",
                columns: table => new
                {
                    jornadaId = table.Column<int>(nullable: false),
                    servicioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jornadasServicios", x => new { x.jornadaId, x.servicioId });
                    table.ForeignKey(
                        name: "FK_jornadasServicios_Jornada_jornadaId",
                        column: x => x.jornadaId,
                        principalTable: "Jornada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_jornadasServicios_servicios_servicioId",
                        column: x => x.servicioId,
                        principalTable: "servicios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_jornadasServicios_servicioId",
                table: "jornadasServicios",
                column: "servicioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jornadasServicios");
        }
    }
}
