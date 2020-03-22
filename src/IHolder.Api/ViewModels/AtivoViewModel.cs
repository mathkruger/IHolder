using IHolder.Api.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.ViewModels
{
    public class AtivoViewModel : Informacoes_baseViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Produto_id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Ticker { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Cotacao { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Risco_id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Situacao_id { get; set; }

        public ProdutoViewModel Produto { get; set; }
        public RiscoViewModel Risco { get; set; }
        public SituacaoViewModel Situacao { get; set; }

        public IEnumerable<Distribuicao_por_ativoViewModel> Distribuicoes_por_ativos { get; set; }

        public IEnumerable<AporteViewModel> Aportes { get; set; }
    }
}
