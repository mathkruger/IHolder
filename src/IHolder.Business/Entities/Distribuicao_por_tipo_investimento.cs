﻿using IHolder.Business.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Distribuicao_por_tipo_investimento : Valores_base
    {
        public int Tipo_investimento_id { get; set; }
        public int Orientacao_id { get; set; }
        public int Usuario_id { get; set; }

        public DateTime Data_inclusao { get; set; }
        public DateTime? Data_alteracao { get; set; }
        public Tipo_investimento Tipo_investimento { get; set; }
        public Orientacao Orientacao { get; set; }
        public Usuario Usuario { get; set; }
        public IEnumerable<Distribuicao_por_produto> Distribuicoes_por_produtos { get; set; }

    }
}
