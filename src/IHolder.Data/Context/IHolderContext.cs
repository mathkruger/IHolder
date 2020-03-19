using IHolder.Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Data.Context
{
    public class IHolderContext : DbContext
    {
        public IHolderContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Aporte> Aportes { get; set; }
        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Distribuicao_por_ativo> Distribuicoes_por_ativos { get; set; }
        public DbSet<Distribuicao_por_produto> Distribuicoes_por_produtos { get; set; }
        public DbSet<Distribuicao_por_tipo_investimento> Distribuicoes_por_tipos_investimentos { get; set; }
        public DbSet<Orientacao> Orientacoes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Risco> Riscos { get; set; }
        public DbSet<Situacao> Situacoes { get; set; }
        public DbSet<Tipo_investimento> Tipos_investimentos { get; set; }
    }
}
