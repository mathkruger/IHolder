using IHolder.Api.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.ViewModels
{
    public class UsuarioViewModel : Entidade_baseViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
    }
}
