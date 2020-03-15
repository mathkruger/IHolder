using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities.Base
{
    public abstract class Info : Entity
    {
        public string Descricao { get; set; }
        public string Caracteristicas { get; set; }
    }
}
