using IHolder.Api.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.ViewModels
{
    public class Distribuicao_por_tipo_investimentoViewModel : Valores_baseViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Tipo_investimento_id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Orientacao_id { get; set; }

        public Tipo_investimentoViewModel Tipo_investimento { get; set; }
        public OrientacaoViewModel Orientacao { get; set; }

        public IEnumerable<Distribuicao_por_produtoViewModel> Distribuicoes_por_produtos { get; set; }
    }
}
