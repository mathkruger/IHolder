using IHolder.Api.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.ViewModels
{
    public class Usuario_autenticacaoViewModel : Entidade_baseViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
