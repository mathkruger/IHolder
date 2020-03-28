using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHolder.Api.Configurations
{
    public class AppSettings
    {
        public string Chave { get; set; }
        public int Expiracao_horas { get; set; }
        public string Valido_em { get; set; }
        public string Emissor { get; set; }
    }
}
