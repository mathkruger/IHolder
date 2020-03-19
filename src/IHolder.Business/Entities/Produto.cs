using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Produto : Informacoes_base
    {
        public int Tipo_investimento_id { get; set; }

        public Tipo_investimento Tipo_investimento { get; set; }

        public IEnumerable<Distribuicao_por_produto> Distribuicoes_por_produtos { get; set; }

    }
}
