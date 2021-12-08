using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EYECANDY2.Migrations
{
    public partial class seriestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Biografia = table.Column<string>(type: "nvarchar(1055)", maxLength: 1055, nullable: true),
                    ImagenUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Sinopsis = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AficheUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorSerie",
                columns: table => new
                {
                    ActoresId = table.Column<int>(type: "int", nullable: false),
                    SeriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorSerie", x => new { x.ActoresId, x.SeriesId });
                    table.ForeignKey(
                        name: "FK_ActorSerie_Actores_ActoresId",
                        column: x => x.ActoresId,
                        principalTable: "Actores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorSerie_Serie_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectorSerie",
                columns: table => new
                {
                    DirectoresId = table.Column<int>(type: "int", nullable: false),
                    SeriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorSerie", x => new { x.DirectoresId, x.SeriesId });
                    table.ForeignKey(
                        name: "FK_DirectorSerie_Director_DirectoresId",
                        column: x => x.DirectoresId,
                        principalTable: "Director",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectorSerie_Serie_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneroSerie",
                columns: table => new
                {
                    GenerosId = table.Column<int>(type: "int", nullable: false),
                    SeriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroSerie", x => new { x.GenerosId, x.SeriesId });
                    table.ForeignKey(
                        name: "FK_GeneroSerie_Generos_GenerosId",
                        column: x => x.GenerosId,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroSerie_Serie_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorSerie_SeriesId",
                table: "ActorSerie",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorSerie_SeriesId",
                table: "DirectorSerie",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroSerie_SeriesId",
                table: "GeneroSerie",
                column: "SeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorSerie");

            migrationBuilder.DropTable(
                name: "DirectorSerie");

            migrationBuilder.DropTable(
                name: "GeneroSerie");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropTable(
                name: "Serie");
        }
    }
}
