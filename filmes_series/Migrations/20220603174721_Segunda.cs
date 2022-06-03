using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace filmes_series.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AtorProducao",
                table: "AtorProducao");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AtorProducao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtorProducao",
                table: "AtorProducao",
                columns: new[] { "ElencoId", "ProducoesId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AtorProducao",
                table: "AtorProducao");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AtorProducao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtorProducao",
                table: "AtorProducao",
                column: "Id");
        }
    }
}
