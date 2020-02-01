using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace apiTurnos.Migrations
{
    public partial class Creaciondeentidadesserviciospreciov2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "servicios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "precios",
                columns: table => new
                {
                    fechahora = table.Column<DateTime>(nullable: false),
                    importe = table.Column<float>(nullable: false),
                    precioid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precios", x => x.fechahora);
                    table.ForeignKey(
                        name: "FK_precios_servicios_precioid",
                        column: x => x.precioid,
                        principalTable: "servicios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_precios_precioid",
                table: "precios",
                column: "precioid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "servicios");
        }
    }
}
