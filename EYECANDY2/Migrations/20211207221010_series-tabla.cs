using Microsoft.EntityFrameworkCore.Migrations;

namespace EYECANDY2.Migrations
{
    public partial class seriestabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorSerie_Serie_SeriesId",
                table: "ActorSerie");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectorSerie_Serie_SeriesId",
                table: "DirectorSerie");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroSerie_Serie_SeriesId",
                table: "GeneroSerie");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ActorSerie_Series_SeriesId",
                table: "ActorSerie",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorSerie_Series_SeriesId",
                table: "DirectorSerie",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroSerie_Series_SeriesId",
                table: "GeneroSerie",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorSerie_Series_SeriesId",
                table: "ActorSerie");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectorSerie_Series_SeriesId",
                table: "DirectorSerie");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneroSerie_Series_SeriesId",
                table: "GeneroSerie");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ActorSerie_Serie_SeriesId",
                table: "ActorSerie",
                column: "SeriesId",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorSerie_Serie_SeriesId",
                table: "DirectorSerie",
                column: "SeriesId",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneroSerie_Serie_SeriesId",
                table: "GeneroSerie",
                column: "SeriesId",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
