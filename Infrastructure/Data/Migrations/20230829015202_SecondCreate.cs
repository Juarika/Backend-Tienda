using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estado_Pais_Id",
                table: "Estado");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Region_Id",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_TipoPersona_Id",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Region_Estado_Id",
                table: "Region");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Region",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Persona",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Estado",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Region_IdEstado",
                table: "Region",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IdRegion",
                table: "Persona",
                column: "IdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IdTipoPer",
                table: "Persona",
                column: "IdTipoPer");

            migrationBuilder.CreateIndex(
                name: "IX_Estado_IdPais",
                table: "Estado",
                column: "IdPais");

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_Pais_IdPais",
                table: "Estado",
                column: "IdPais",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Region_IdRegion",
                table: "Persona",
                column: "IdRegion",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_TipoPersona_IdTipoPer",
                table: "Persona",
                column: "IdTipoPer",
                principalTable: "TipoPersona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Region_Estado_IdEstado",
                table: "Region",
                column: "IdEstado",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estado_Pais_IdPais",
                table: "Estado");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Region_IdRegion",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_TipoPersona_IdTipoPer",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Region_Estado_IdEstado",
                table: "Region");

            migrationBuilder.DropIndex(
                name: "IX_Region_IdEstado",
                table: "Region");

            migrationBuilder.DropIndex(
                name: "IX_Persona_IdRegion",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_IdTipoPer",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Estado_IdPais",
                table: "Estado");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Region",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Persona",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Estado",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Estado_Pais_Id",
                table: "Estado",
                column: "Id",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Region_Id",
                table: "Persona",
                column: "Id",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_TipoPersona_Id",
                table: "Persona",
                column: "Id",
                principalTable: "TipoPersona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Region_Estado_Id",
                table: "Region",
                column: "Id",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
