using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IHolder.Data.Migrations
{
    public partial class AddingUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data_alteracao",
                table: "Distribuicao_por_tipo_investimento",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_inclusao",
                table: "Distribuicao_por_tipo_investimento",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Usuario_id",
                table: "Distribuicao_por_tipo_investimento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_alteracao",
                table: "Distribuicao_por_produto",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_inclusao",
                table: "Distribuicao_por_produto",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Usuario_id",
                table: "Distribuicao_por_produto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_alteracao",
                table: "Distribuicao_por_ativo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_inclusao",
                table: "Distribuicao_por_ativo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Usuario_id",
                table: "Distribuicao_por_ativo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Ticker",
                table: "Ativo",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_alteracao",
                table: "Ativo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_inclusao",
                table: "Ativo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Usuario_id",
                table: "Ativo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_alteracao",
                table: "Aporte",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_aporte",
                table: "Aporte",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_inclusao",
                table: "Aporte",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Usuario_id",
                table: "Aporte",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(25)", nullable: false),
                    Celular = table.Column<string>(type: "VARCHAR(25)", nullable: false),
                    Data_nascimento = table.Column<DateTime>(nullable: false),
                    Genero = table.Column<byte>(type: "TINYINT", nullable: false),
                    Data_inclusao = table.Column<DateTime>(nullable: false),
                    Data_alteracao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.UniqueConstraint("AK_Usuario_CPF", x => x.CPF);
                    table.UniqueConstraint("AK_Usuario_Celular", x => x.Celular);
                    table.UniqueConstraint("AK_Usuario_Email", x => x.Email);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_tipo_investimento_Usuario_id",
                table: "Distribuicao_por_tipo_investimento",
                column: "Usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_produto_Usuario_id",
                table: "Distribuicao_por_produto",
                column: "Usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_ativo_Usuario_id",
                table: "Distribuicao_por_ativo",
                column: "Usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ativo_Usuario_id",
                table: "Ativo",
                column: "Usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Aporte_Usuario_id",
                table: "Aporte",
                column: "Usuario_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aporte_Usuario_Usuario_id",
                table: "Aporte",
                column: "Usuario_id",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ativo_Usuario_Usuario_id",
                table: "Ativo",
                column: "Usuario_id",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Distribuicao_por_ativo_Usuario_Usuario_id",
                table: "Distribuicao_por_ativo",
                column: "Usuario_id",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Distribuicao_por_produto_Usuario_Usuario_id",
                table: "Distribuicao_por_produto",
                column: "Usuario_id",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Distribuicao_por_tipo_investimento_Usuario_Usuario_id",
                table: "Distribuicao_por_tipo_investimento",
                column: "Usuario_id",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aporte_Usuario_Usuario_id",
                table: "Aporte");

            migrationBuilder.DropForeignKey(
                name: "FK_Ativo_Usuario_Usuario_id",
                table: "Ativo");

            migrationBuilder.DropForeignKey(
                name: "FK_Distribuicao_por_ativo_Usuario_Usuario_id",
                table: "Distribuicao_por_ativo");

            migrationBuilder.DropForeignKey(
                name: "FK_Distribuicao_por_produto_Usuario_Usuario_id",
                table: "Distribuicao_por_produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Distribuicao_por_tipo_investimento_Usuario_Usuario_id",
                table: "Distribuicao_por_tipo_investimento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Distribuicao_por_tipo_investimento_Usuario_id",
                table: "Distribuicao_por_tipo_investimento");

            migrationBuilder.DropIndex(
                name: "IX_Distribuicao_por_produto_Usuario_id",
                table: "Distribuicao_por_produto");

            migrationBuilder.DropIndex(
                name: "IX_Distribuicao_por_ativo_Usuario_id",
                table: "Distribuicao_por_ativo");

            migrationBuilder.DropIndex(
                name: "IX_Ativo_Usuario_id",
                table: "Ativo");

            migrationBuilder.DropIndex(
                name: "IX_Aporte_Usuario_id",
                table: "Aporte");

            migrationBuilder.DropColumn(
                name: "Data_alteracao",
                table: "Distribuicao_por_tipo_investimento");

            migrationBuilder.DropColumn(
                name: "Data_inclusao",
                table: "Distribuicao_por_tipo_investimento");

            migrationBuilder.DropColumn(
                name: "Usuario_id",
                table: "Distribuicao_por_tipo_investimento");

            migrationBuilder.DropColumn(
                name: "Data_alteracao",
                table: "Distribuicao_por_produto");

            migrationBuilder.DropColumn(
                name: "Data_inclusao",
                table: "Distribuicao_por_produto");

            migrationBuilder.DropColumn(
                name: "Usuario_id",
                table: "Distribuicao_por_produto");

            migrationBuilder.DropColumn(
                name: "Data_alteracao",
                table: "Distribuicao_por_ativo");

            migrationBuilder.DropColumn(
                name: "Data_inclusao",
                table: "Distribuicao_por_ativo");

            migrationBuilder.DropColumn(
                name: "Usuario_id",
                table: "Distribuicao_por_ativo");

            migrationBuilder.DropColumn(
                name: "Data_alteracao",
                table: "Ativo");

            migrationBuilder.DropColumn(
                name: "Data_inclusao",
                table: "Ativo");

            migrationBuilder.DropColumn(
                name: "Usuario_id",
                table: "Ativo");

            migrationBuilder.DropColumn(
                name: "Data_alteracao",
                table: "Aporte");

            migrationBuilder.DropColumn(
                name: "Data_aporte",
                table: "Aporte");

            migrationBuilder.DropColumn(
                name: "Data_inclusao",
                table: "Aporte");

            migrationBuilder.DropColumn(
                name: "Usuario_id",
                table: "Aporte");

            migrationBuilder.AlterColumn<string>(
                name: "Ticker",
                table: "Ativo",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");
        }
    }
}
