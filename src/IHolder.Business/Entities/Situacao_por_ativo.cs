using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Situacao_por_ativo : Entidade_base
    {
        public int Situacao_id { get; set; }
        public int Ativo_id { get; set; }
        public int Usuario_id { get; set; }
        public string Observacao { get; set; }
        public DateTime Data_inclusao { get; set; }
        public DateTime? Data_alteracao { get; set; }
        public Situacao Situacao { get; set; }
        public Ativo Ativo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
