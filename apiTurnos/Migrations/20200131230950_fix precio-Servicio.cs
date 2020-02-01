using Microsoft.EntityFrameworkCore.Migrations;

namespace apiTurnos.Migrations
{
    public partial class fixprecioServicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_precios_servicios_precioid",
                table: "precios");

            migrationBuilder.DropIndex(
                name: "IX_precios_precioid",
                table: "precios");

            migrationBuilder.DropColumn(
                name: "precioid",
                table: "precios");

            migrationBuilder.AddColumn<int>(
                name: "servicioIdid",
                table: "precios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_precios_servicioIdid",
                table: "precios",
                column: "servicioIdid");

            migrationBuilder.AddForeignKey(
                name: "FK_precios_servicios_servicioIdid",
                table: "precios",
                column: "servicioIdid",
                principalTable: "servicios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_precios_servicios_servicioIdid",
                table: "precios");

            migrationBuilder.DropIndex(
                name: "IX_precios_servicioIdid",
                table: "precios");

            migrationBuilder.DropColumn(
                name: "servicioIdid",
                table: "precios");

            migrationBuilder.AddColumn<int>(
                name: "precioid",
                table: "precios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_precios_precioid",
                table: "precios",
                column: "precioid");

            migrationBuilder.AddForeignKey(
                name: "FK_precios_servicios_precioid",
                table: "precios",
                column: "precioid",
                principalTable: "servicios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
