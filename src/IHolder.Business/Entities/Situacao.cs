using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Situacao : Informacoes_base
    {
        public IEnumerable<Situacao_por_ativo> Situacoes_por_ativos { get; set; }
    }
}
