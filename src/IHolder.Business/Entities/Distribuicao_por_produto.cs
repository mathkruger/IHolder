using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Distribuicao_por_produto : Valores_base
    {
        public int Distribuicao_por_tipo_investimento_id { get; set; }
        public int Produto_id { get; set; }
        public int Orientacao_id { get; set; }
        public Distribuicao_por_tipo_investimento Distribuicao_por_tipo_investimento { get; set; }
        public Produto Produto { get; set; }
        public Orientacao Orientacao { get; set; }

    }
}
