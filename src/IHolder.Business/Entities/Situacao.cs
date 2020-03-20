using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Situacao : Informacoes_base
    {
        public IEnumerable<Ativo> Ativos { get; set; }
    }
}
