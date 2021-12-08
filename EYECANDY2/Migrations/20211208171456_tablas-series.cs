using Microsoft.EntityFrameworkCore.Migrations;

namespace EYECANDY2.Migrations
{
    public partial class tablasseries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectorSerie_Serie_SeriesId",
                table: "DirectorSerie");

            migrationBuilder.DropTable(
                name: "ActorSerie");

            migrationBuilder.DropTable(
                name: "GeneroSerie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Serie",
                table: "Serie");

            migrationBuilder.RenameTable(
                name: "Serie",
                newName: "Series");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Series",
                table: "Series",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SeriesActores",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesActores", x => new { x.ActorId, x.SerieId });
                    table.ForeignKey(
                        name: "FK_SeriesActores_Actores_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeriesActores_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeriesGeneros",
                columns: table => new
                {
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesGeneros", x => new { x.SerieId, x.GeneroId });
                    table.ForeignKey(
                        name: "FK_SeriesGeneros_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeriesGeneros_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeriesActores_SerieId",
                table: "SeriesActores",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesGeneros_GeneroId",
                table: "SeriesGeneros",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorSerie_Series_SeriesId",
                table: "DirectorSerie",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectorSerie_Series_SeriesId",
                table: "DirectorSerie");

            migrationBuilder.DropTable(
                name: "SeriesActores");

            migrationBuilder.DropTable(
                name: "SeriesGeneros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Series",
                table: "Series");

            migrationBuilder.RenameTable(
                name: "Series",
                newName: "Serie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Serie",
                table: "Serie",
                column: "Id");

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
                name: "IX_GeneroSerie_SeriesId",
                table: "GeneroSerie",
                column: "SeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorSerie_Serie_SeriesId",
                table: "DirectorSerie",
                column: "SeriesId",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
