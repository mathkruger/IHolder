using IHolder.Api.ViewModels.Base;
using IHolder.Business.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.ViewModels
{
    public class UsuarioViewModel : Entidade_baseViewModel
    {
        public UsuarioViewModel()
        {
            if (this.Id > 0)
                this.Data_alteracao = DateTime.Now;
            else
                this.Data_inclusao = DateTime.Now;
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public DateTime Data_nascimento { get; set; }
        public EGenero Genero { get; set; }
        public DateTime Data_inclusao { get; set; }
        public DateTime? Data_alteracao { get; set; }
        public string Token { get; set; }
        public DateTime Expira_em { get; set; }
    }
}
