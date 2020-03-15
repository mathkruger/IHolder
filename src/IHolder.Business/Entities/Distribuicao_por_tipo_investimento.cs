using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Distribuicao_por_tipo_investimento : Valores
    {
        public int Tipo_investimento_id { get; set; }
        public int Orientacao_id { get; set; }
    }
}
