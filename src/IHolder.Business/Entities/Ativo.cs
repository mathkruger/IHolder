using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Ativo : Informacoes_base
    {
        public int Produto_id { get; set; }
        public string Ticker { get; set; }
        public decimal Cotacao { get; set; }
        public int Risco_id { get; set; }
        //public int Situacao_id { get; set; }
        public int Usuario_id { get; set; }
        public DateTime Data_inclusao { get; set; }
        public DateTime? Data_alteracao { get; set; }
        public Produto Produto { get; set; }    
        public Risco Risco { get; set; }
        //public Situacao Situacao { get; set; }

        public Usuario Usuario { get; set; }
        public IEnumerable<Distribuicao_por_ativo> Distribuicoes_por_ativos { get; set; }
        public IEnumerable<Aporte> Aportes { get; set; }

        public IEnumerable<Situacao_por_ativo> Situacoes_por_ativos { get; set; }
    }
}
