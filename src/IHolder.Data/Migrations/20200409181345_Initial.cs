using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IHolder.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orientacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Caracteristicas = table.Column<string>(type: "VARCHAR(240)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orientacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Risco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Caracteristicas = table.Column<string>(type: "VARCHAR(240)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Situacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Caracteristicas = table.Column<string>(type: "VARCHAR(240)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(240)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Tipo_investimento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Caracteristicas = table.Column<string>(type: "VARCHAR(240)", nullable: false),
                    Risco_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_investimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tipo_investimento_Risco_Risco_id",
                        column: x => x.Risco_id,
                        principalTable: "Risco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Distribuicao_por_tipo_investimento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percentual_objetivo = table.Column<decimal>(nullable: false),
                    Percentual_atual = table.Column<decimal>(nullable: false),
                    Percentual_diferenca = table.Column<decimal>(nullable: false),
                    Valor_atual = table.Column<decimal>(nullable: false),
                    Valor_diferenca = table.Column<decimal>(nullable: false),
                    Tipo_investimento_id = table.Column<int>(nullable: false),
                    Orientacao_id = table.Column<int>(nullable: false),
                    Usuario_id = table.Column<int>(nullable: false),
                    Data_inclusao = table.Column<DateTime>(nullable: false),
                    Data_alteracao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuicao_por_tipo_investimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Distribuicao_por_tipo_investimento_Orientacao_Orientacao_id",
                        column: x => x.Orientacao_id,
                        principalTable: "Orientacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribuicao_por_tipo_investimento_Tipo_investimento_Tipo_investimento_id",
                        column: x => x.Tipo_investimento_id,
                        principalTable: "Tipo_investimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribuicao_por_tipo_investimento_Usuario_Usuario_id",
                        column: x => x.Usuario_id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Caracteristicas = table.Column<string>(type: "VARCHAR(240)", nullable: false),
                    Tipo_investimento_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Tipo_investimento_Tipo_investimento_id",
                        column: x => x.Tipo_investimento_id,
                        principalTable: "Tipo_investimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ativo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Caracteristicas = table.Column<string>(type: "VARCHAR(240)", nullable: false),
                    Produto_id = table.Column<int>(nullable: false),
                    Ticker = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Cotacao = table.Column<decimal>(nullable: false),
                    Risco_id = table.Column<int>(nullable: false),
                    Usuario_id = table.Column<int>(nullable: false),
                    Data_inclusao = table.Column<DateTime>(nullable: false),
                    Data_alteracao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ativo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ativo_Produto_Produto_id",
                        column: x => x.Produto_id,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ativo_Risco_Risco_id",
                        column: x => x.Risco_id,
                        principalTable: "Risco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ativo_Usuario_Usuario_id",
                        column: x => x.Usuario_id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Distribuicao_por_produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percentual_objetivo = table.Column<decimal>(nullable: false),
                    Percentual_atual = table.Column<decimal>(nullable: false),
                    Percentual_diferenca = table.Column<decimal>(nullable: false),
                    Valor_atual = table.Column<decimal>(nullable: false),
                    Valor_diferenca = table.Column<decimal>(nullable: false),
                    Distribuicao_por_tipo_investimento_id = table.Column<int>(nullable: false),
                    Produto_id = table.Column<int>(nullable: false),
                    Orientacao_id = table.Column<int>(nullable: false),
                    Usuario_id = table.Column<int>(nullable: false),
                    Data_inclusao = table.Column<DateTime>(nullable: false),
                    Data_alteracao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuicao_por_produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Distribuicao_por_produto_Distribuicao_por_tipo_investimento_Distribuicao_por_tipo_investimento_id",
                        column: x => x.Distribuicao_por_tipo_investimento_id,
                        principalTable: "Distribuicao_por_tipo_investimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribuicao_por_produto_Orientacao_Orientacao_id",
                        column: x => x.Orientacao_id,
                        principalTable: "Orientacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribuicao_por_produto_Produto_Produto_id",
                        column: x => x.Produto_id,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribuicao_por_produto_Usuario_Usuario_id",
                        column: x => x.Usuario_id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aporte",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo_id = table.Column<int>(nullable: false),
                    Preco_medio = table.Column<decimal>(nullable: false),
                    Quantidade = table.Column<decimal>(nullable: false),
                    Usuario_id = table.Column<int>(nullable: false),
                    Data_aporte = table.Column<DateTime>(nullable: false),
                    Data_inclusao = table.Column<DateTime>(nullable: false),
                    Data_alteracao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aporte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aporte_Ativo_Ativo_id",
                        column: x => x.Ativo_id,
                        principalTable: "Ativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aporte_Usuario_Usuario_id",
                        column: x => x.Usuario_id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Distribuicao_por_ativo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percentual_objetivo = table.Column<decimal>(nullable: false),
                    Percentual_atual = table.Column<decimal>(nullable: false),
                    Percentual_diferenca = table.Column<decimal>(nullable: false),
                    Valor_atual = table.Column<decimal>(nullable: false),
                    Valor_diferenca = table.Column<decimal>(nullable: false),
                    Ativo_id = table.Column<int>(nullable: false),
                    Orientacao_id = table.Column<int>(nullable: false),
                    Usuario_id = table.Column<int>(nullable: false),
                    Data_inclusao = table.Column<DateTime>(nullable: false),
                    Data_alteracao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuicao_por_ativo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Distribuicao_por_ativo_Ativo_Ativo_id",
                        column: x => x.Ativo_id,
                        principalTable: "Ativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribuicao_por_ativo_Orientacao_Orientacao_id",
                        column: x => x.Orientacao_id,
                        principalTable: "Orientacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distribuicao_por_ativo_Usuario_Usuario_id",
                        column: x => x.Usuario_id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Aporte_Ativo_id",
                table: "Aporte",
                column: "Ativo_id");

            migrationBuilder.CreateIndex(
                name: "IX_Aporte_Usuario_id",
                table: "Aporte",
                column: "Usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ativo_Produto_id",
                table: "Ativo",
                column: "Produto_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ativo_Risco_id",
                table: "Ativo",
                column: "Risco_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ativo_Usuario_id",
                table: "Ativo",
                column: "Usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_ativo_Ativo_id",
                table: "Distribuicao_por_ativo",
                column: "Ativo_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_ativo_Orientacao_id",
                table: "Distribuicao_por_ativo",
                column: "Orientacao_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_ativo_Usuario_id",
                table: "Distribuicao_por_ativo",
                column: "Usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_produto_Distribuicao_por_tipo_investimento_id",
                table: "Distribuicao_por_produto",
                column: "Distribuicao_por_tipo_investimento_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_produto_Orientacao_id",
                table: "Distribuicao_por_produto",
                column: "Orientacao_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_produto_Produto_id",
                table: "Distribuicao_por_produto",
                column: "Produto_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_produto_Usuario_id",
                table: "Distribuicao_por_produto",
                column: "Usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_tipo_investimento_Orientacao_id",
                table: "Distribuicao_por_tipo_investimento",
                column: "Orientacao_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_tipo_investimento_Tipo_investimento_id",
                table: "Distribuicao_por_tipo_investimento",
                column: "Tipo_investimento_id");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuicao_por_tipo_investimento_Usuario_id",
                table: "Distribuicao_por_tipo_investimento",
                column: "Usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Tipo_investimento_id",
                table: "Produto",
                column: "Tipo_investimento_id");

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

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_investimento_Risco_id",
                table: "Tipo_investimento",
                column: "Risco_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aporte");

            migrationBuilder.DropTable(
                name: "Distribuicao_por_ativo");

            migrationBuilder.DropTable(
                name: "Distribuicao_por_produto");

            migrationBuilder.DropTable(
                name: "Situacao_por_ativo");

            migrationBuilder.DropTable(
                name: "Distribuicao_por_tipo_investimento");

            migrationBuilder.DropTable(
                name: "Ativo");

            migrationBuilder.DropTable(
                name: "Situacao");

            migrationBuilder.DropTable(
                name: "Orientacao");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Tipo_investimento");

            migrationBuilder.DropTable(
                name: "Risco");
        }
    }
}
