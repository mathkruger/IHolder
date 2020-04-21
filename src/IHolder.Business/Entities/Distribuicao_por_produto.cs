using IHolder.Business.Entities.Base;
using IHolder.Business.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Distribuicao_por_produto : Valores_base
    {
        public Distribuicao_por_produto(decimal percentual_objetivo) : base(percentual_objetivo)
        {
        }

        public Guid Distribuicao_por_tipo_investimento_id { get; set; }
        public Guid Produto_id { get; set; }
        public Guid Orientacao_id { get; set; }
        public Guid Usuario_id { get; set; }
        public DateTime Data_inclusao { get; set; }
        public DateTime? Data_alteracao { get; set; }
        public Distribuicao_por_tipo_investimento Distribuicao_por_tipo_investimento { get; set; }
        public Produto Produto { get; set; }
        public EOrientacao Orientacao { get; set; }
        public Usuario Usuario { get; set; }

    }
}
