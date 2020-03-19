using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Risco : Informacoes_base
    {
        public IEnumerable<Tipo_investimento> Tipos_investimentos { get; set; }
    }
}
