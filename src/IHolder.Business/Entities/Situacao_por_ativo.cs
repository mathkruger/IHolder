using IHolder.Business.Entities.Base;
using IHolder.Business.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Situacao_por_ativo : Entidade_base
    {
        public ESituacao Situacao { get; set; }
        public Guid Ativo_id { get; set; }
        public Guid Usuario_id { get; set; }
        public string Observacao { get; set; }
        public DateTime Data_inclusao { get; set; }
        public DateTime? Data_alteracao { get; set; }
        public Ativo Ativo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
