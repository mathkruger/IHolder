using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities.Base
{
    public abstract class Informacoes_base : Entidade_base
    {
        public string Descricao { get; set; }
        public string Caracteristicas { get; set; }
    }
}
