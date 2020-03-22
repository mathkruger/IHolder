using IHolder.Api.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.ViewModels
{
    public class RiscoViewModel : Informacoes_baseViewModel
    {
        public IEnumerable<Tipo_investimentoViewModel> Tipos_investimentos { get; set; }
        public IEnumerable<AtivoViewModel> Ativos { get; set; }
    }
}
