using IHolder.Api.ViewModels.Base;
using IHolder.Business.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.ViewModels
{
    public class Tipo_investimentoViewModel : Informacoes_baseViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, Int32.MaxValue, ErrorMessage ="Um codigo do rísco de investimento deve ser informado")]
        public ERisco Risco { get; set; }
        public IEnumerable<Distribuicao_por_tipo_investimentoViewModel> Distribuicoes_por_tipos_investimentos { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
