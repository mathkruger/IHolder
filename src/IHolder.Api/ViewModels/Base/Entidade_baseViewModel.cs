using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.ViewModels.Base
{
    public class Entidade_baseViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
