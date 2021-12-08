using Microsoft.EntityFrameworkCore.Migrations;

namespace EYECANDY2.Migrations
{
    public partial class direct_actu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectorSerie_Director_DirectoresId",
                table: "DirectorSerie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                table: "Director");

            migrationBuilder.RenameTable(
                name: "Director",
                newName: "Directores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directores",
                table: "Directores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorSerie_Directores_DirectoresId",
                table: "DirectorSerie",
                column: "DirectoresId",
                principalTable: "Directores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectorSerie_Directores_DirectoresId",
                table: "DirectorSerie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directores",
                table: "Directores");

            migrationBuilder.RenameTable(
                name: "Directores",
                newName: "Director");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                table: "Director",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectorSerie_Director_DirectoresId",
                table: "DirectorSerie",
                column: "DirectoresId",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
