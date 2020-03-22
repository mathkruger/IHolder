using IHolder.Api.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.ViewModels
{
    public class Distribuicao_por_ativoViewModel : Valores_baseViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Ativo_id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Orientacao_id { get; set; }

        public AtivoViewModel Ativo { get; set; }
        public OrientacaoViewModel Orientacao { get; set; }
    }
}
