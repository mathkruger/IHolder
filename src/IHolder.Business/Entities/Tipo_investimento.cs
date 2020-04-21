using IHolder.Business.Entities.Base;
using IHolder.Business.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Entities
{
    public class Tipo_investimento : Informacoes_base
    {
        public Tipo_investimento(string descricao, string caracteristicas) : base(descricao, caracteristicas)
        {
        }

        public Guid Risco_id { get; set; }
        public ERisco Risco { get; set; }
        public IEnumerable<Distribuicao_por_tipo_investimento> Distribuicoes_por_tipos_investimentos { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
