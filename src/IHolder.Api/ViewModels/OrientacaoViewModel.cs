using IHolder.Api.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.ViewModels
{
    public class OrientacaoViewModel : Informacoes_baseViewModel
    {
        public IEnumerable<Distribuicao_por_tipo_investimentoViewModel> Distribuicoes_por_tipos_investimentos { get; set; }

        public IEnumerable<Distribuicao_por_produtoViewModel> Distribuicoes_por_produtos { get; set; }

        public IEnumerable<Distribuicao_por_ativoViewModel> Distribuicoes_por_ativos { get; set; }
    }
}
