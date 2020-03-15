using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Aporte : Entity
    {
        public int Ativo_id { get; set; }
        public decimal Preco_medio { get; set; }
        public decimal Quantidade { get; set; }
    }
}
