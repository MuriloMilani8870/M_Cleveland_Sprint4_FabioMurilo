using System;
using System.Collections.Generic;

namespace M_Cleveland_FabioMurilo.Domains
{
    public partial class Medico
    {
        public int IdMedico { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int? Crm { get; set; }
        public string AreaAtuacao { get; set; }
        public bool? Ativo { get; set; }
    }
}
