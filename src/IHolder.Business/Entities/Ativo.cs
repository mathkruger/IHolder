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
        public int Situacao_id { get; set; }
    }
}
