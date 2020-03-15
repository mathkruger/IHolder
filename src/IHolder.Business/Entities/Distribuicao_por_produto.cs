using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Distribuicao_por_produto : Valores
    {
        public int Distribuicao_por_tipo_investimento_id { get; set; }
        public int Produto_id { get; set; }
        public int Orientacao_id { get; set; }
    }
}
