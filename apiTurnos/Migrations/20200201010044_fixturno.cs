using Microsoft.EntityFrameworkCore.Migrations;

namespace apiTurnos.Migrations
{
    public partial class fixturno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "jornadaServiciojornadaId",
                table: "turnos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jornadaServicioservicioId",
                table: "turnos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_turnos_jornadaServiciojornadaId_jornadaServicioservicioId",
                table: "turnos",
                columns: new[] { "jornadaServiciojornadaId", "jornadaServicioservicioId" });

            migrationBuilder.AddForeignKey(
                name: "FK_turnos_jornadasServicios_jornadaServiciojornadaId_jornadaServicioservicioId",
                table: "turnos",
                columns: new[] { "jornadaServiciojornadaId", "jornadaServicioservicioId" },
                principalTable: "jornadasServicios",
                principalColumns: new[] { "jornadaId", "servicioId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turnos_jornadasServicios_jornadaServiciojornadaId_jornadaServicioservicioId",
                table: "turnos");

            migrationBuilder.DropIndex(
                name: "IX_turnos_jornadaServiciojornadaId_jornadaServicioservicioId",
                table: "turnos");

            migrationBuilder.DropColumn(
                name: "jornadaServiciojornadaId",
                table: "turnos");

            migrationBuilder.DropColumn(
                name: "jornadaServicioservicioId",
                table: "turnos");
        }
    }
}
