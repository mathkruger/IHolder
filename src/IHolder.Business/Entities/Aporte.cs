using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Aporte : Entidade_base
    {
        public int Ativo_id { get; set; }
        public decimal Preco_medio { get; set; }
        public decimal Quantidade { get; set; }
        public int Usuario_id { get; set; }
        public DateTime Data_aporte { get; set; }
        public DateTime Data_inclusao { get; set; }
        public DateTime? Data_alteracao { get; set; }
        public Ativo Ativo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
