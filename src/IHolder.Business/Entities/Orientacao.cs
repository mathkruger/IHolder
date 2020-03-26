using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Orientacao : Informacoes_base
    {
        public IEnumerable<Distribuicao_por_tipo_investimento> Distribuicoes_por_tipos_investimentos { get; set; }
        public IEnumerable<Distribuicao_por_produto> Distribuicoes_por_produtos { get; set; }
        public IEnumerable<Distribuicao_por_ativo> Distribuicoes_por_ativos { get; set; }

    }
}
