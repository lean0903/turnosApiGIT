using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace apiTurnos.Migrations
{
    public partial class finmodev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jornada_Empresas_empresaid",
                table: "Jornada");

            migrationBuilder.DropForeignKey(
                name: "FK_jornadasServicios_Jornada_jornadaId",
                table: "jornadasServicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jornada",
                table: "Jornada");

            migrationBuilder.RenameTable(
                name: "Empresas",
                newName: "empresas");

            migrationBuilder.RenameTable(
                name: "Jornada",
                newName: "jornadas");

            migrationBuilder.RenameIndex(
                name: "IX_Jornada_empresaid",
                table: "jornadas",
                newName: "IX_jornadas_empresaid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_empresas",
                table: "empresas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jornadas",
                table: "jornadas",
                column: "id");

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    dni = table.Column<string>(nullable: false),
                    fechaNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(nullable: true),
                    nombre = table.Column<string>(nullable: true),
                    Usuarioid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.id);
                    table.ForeignKey(
                        name: "FK_roles_usuarios_Usuarioid",
                        column: x => x.Usuarioid,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "turnos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turnos", x => x.id);
                    table.ForeignKey(
                        name: "FK_turnos_usuarios_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_roles_Usuarioid",
                table: "roles",
                column: "Usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_turnos_usuarioid",
                table: "turnos",
                column: "usuarioid");

            migrationBuilder.AddForeignKey(
                name: "FK_jornadas_empresas_empresaid",
                table: "jornadas",
                column: "empresaid",
                principalTable: "empresas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_jornadasServicios_jornadas_jornadaId",
                table: "jornadasServicios",
                column: "jornadaId",
                principalTable: "jornadas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_jornadas_empresas_empresaid",
                table: "jornadas");

            migrationBuilder.DropForeignKey(
                name: "FK_jornadasServicios_jornadas_jornadaId",
                table: "jornadasServicios");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "turnos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empresas",
                table: "empresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jornadas",
                table: "jornadas");

            migrationBuilder.RenameTable(
                name: "empresas",
                newName: "Empresas");

            migrationBuilder.RenameTable(
                name: "jornadas",
                newName: "Jornada");

            migrationBuilder.RenameIndex(
                name: "IX_jornadas_empresaid",
                table: "Jornada",
                newName: "IX_Jornada_empresaid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jornada",
                table: "Jornada",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jornada_Empresas_empresaid",
                table: "Jornada",
                column: "empresaid",
                principalTable: "Empresas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_jornadasServicios_Jornada_jornadaId",
                table: "jornadasServicios",
                column: "jornadaId",
                principalTable: "Jornada",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
