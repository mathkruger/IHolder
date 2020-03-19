using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Tipo_investimento : Informacoes_base
    {
        public int Risco_id { get; set; }
        public Risco Risco { get; set; }

        public IEnumerable<Distribuicao_por_tipo_investimento> Distribuicoes_por_tipos_investimentos { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}
