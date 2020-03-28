using IHolder.Business.Entities.Base;
using IHolder.Business.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Usuario : Entidade_base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public DateTime Data_nascimento { get; set; }
        public EGenero Genero { get; set; }

        public DateTime Data_inclusao { get; set; }
        public DateTime? Data_alteracao { get; set; }

        public IEnumerable<Distribuicao_por_tipo_investimento> Distribuicoes_por_tipos_investimentos { get; set; }
        public IEnumerable<Distribuicao_por_ativo> Distribuicoes_por_ativos { get; set; }
        public IEnumerable<Distribuicao_por_produto> Distribuicoes_por_produtos { get; set; }
        public IEnumerable<Ativo> Ativos { get; set; }
        public IEnumerable<Aporte> Aportes { get; set; }
        public IEnumerable<Situacao_por_ativo> Situacoes_por_ativos { get; set; }

    }


}
