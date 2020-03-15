using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities.Base
{
    public abstract class Valores : Entity
    {
        public decimal Percentual_objetivo { get; set; }
        public decimal Percentual_atual { get; set; }
        public decimal Percentual_diferenca { get; set; }
        public decimal Valor_atual { get; set; }
        public decimal Valor_diferenca { get; set; }
    }
}
