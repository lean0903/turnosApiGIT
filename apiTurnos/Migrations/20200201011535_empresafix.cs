using Microsoft.EntityFrameworkCore.Migrations;

namespace apiTurnos.Migrations
{
    public partial class empresafix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "empresaid",
                table: "servicios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_servicios_empresaid",
                table: "servicios",
                column: "empresaid");

            migrationBuilder.AddForeignKey(
                name: "FK_servicios_empresas_empresaid",
                table: "servicios",
                column: "empresaid",
                principalTable: "empresas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_servicios_empresas_empresaid",
                table: "servicios");

            migrationBuilder.DropIndex(
                name: "IX_servicios_empresaid",
                table: "servicios");

            migrationBuilder.DropColumn(
                name: "empresaid",
                table: "servicios");
        }
    }
}
