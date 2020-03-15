using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Distribuicao_por_ativo : Valores
    {
        public int Ativo_id { get; set; }
        public int Orientacao_id { get; set; }
    }
}
