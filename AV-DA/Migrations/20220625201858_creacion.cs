using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AV.DA.Migrations
{
    public partial class creacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VarChar(100)", nullable: false),
                    Descripcion = table.Column<string>(type: "VarChar(300)", nullable: false),
                    Tipo = table.Column<string>(type: "VarChar(30)", nullable: false),
                    ImagenPortada = table.Column<byte[]>(type: "image", nullable: false),
                    Lugar = table.Column<string>(type: "VarChar(100)", nullable: false),
                    NroCupos = table.Column<int>(type: "Int", nullable: false),
                    CantidadMesas = table.Column<int>(type: "Integer", nullable: false),
                    CantidadAsientosMesa = table.Column<int>(type: "Integer", nullable: false),
                    PrecioAsiento = table.Column<int>(type: "Integer", nullable: false),
                    Idioma = table.Column<string>(type: "VarChar(20)", nullable: false),
                    CriterioAsignacion = table.Column<string>(type: "VarChar(20)", nullable: false),
                    EmpresaCreadora = table.Column<string>(type: "Varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
