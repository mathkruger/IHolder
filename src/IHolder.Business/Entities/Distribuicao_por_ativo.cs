﻿using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Distribuicao_por_ativo : Valores_base
    {
        public int Ativo_id { get; set; }
        public int Orientacao_id { get; set; }
        public int Usuario_id { get; set; }

        public DateTime Data_inclusao { get; set; }
        public DateTime? Data_alteracao { get; set; }
        public Ativo Ativo { get; set; }
        public Orientacao Orientacao { get; set; }
        public Usuario Usuario { get; set; }

    }
}
