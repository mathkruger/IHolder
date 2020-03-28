using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IHolder.Data.Migrations
{
    public partial class AddingNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ativo_Situacao_Situacao_id",
                table: "Ativo");

            migrationBuilder.DropIndex(
                name: "IX_Ativo_Situacao_id",
                table: "Ativo");

            migrationBuilder.DropColumn(
                name: "Situacao_id",
                table: "Ativo");

            migrationBuilder.AlterColumn<int>(
                name: "Usuario_id",
                table: "Ativo",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Situacao_por_ativo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Situacao_id = table.Column<int>(nullable: false),
                    Ativo_id = table.Column<int>(nullable: false),
                    Usuario_id = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(type: "VARCHAR(240)", nullable: true),
                    Data_inclusao = table.Column<DateTime>(nullable: false),
                    Data_alteracao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situacao_por_ativo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Situacao_por_ativo_Ativo_Ativo_id",
                        column: x => x.Ativo_id,
                        principalTable: "Ativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Situacao_por_ativo_Situacao_Situacao_id",
                        column: x => x.Situacao_id,
                        principalTable: "Situacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Situacao_por_ativo_Usuario_Usuario_id",
                        column: x => x.Usuario_id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Situacao_por_ativo_Ativo_id",
                table: "Situacao_por_ativo",
                column: "Ativo_id");

            migrationBuilder.CreateIndex(
                name: "IX_Situacao_por_ativo_Situacao_id",
                table: "Situacao_por_ativo",
                column: "Situacao_id");

            migrationBuilder.CreateIndex(
                name: "IX_Situacao_por_ativo_Usuario_id",
                table: "Situacao_por_ativo",
                column: "Usuario_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Situacao_por_ativo");

            migrationBuilder.AlterColumn<int>(
                name: "Usuario_id",
                table: "Ativo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Situacao_id",
                table: "Ativo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ativo_Situacao_id",
                table: "Ativo",
                column: "Situacao_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ativo_Situacao_Situacao_id",
                table: "Ativo",
                column: "Situacao_id",
                principalTable: "Situacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
