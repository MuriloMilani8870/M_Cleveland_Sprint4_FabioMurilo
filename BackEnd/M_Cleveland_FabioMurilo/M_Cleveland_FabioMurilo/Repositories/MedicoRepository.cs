using M_Cleveland_FabioMurilo.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M_Cleveland_FabioMurilo.Repositories
{
    public class MedicoRepository
    {
        /// <summary>
        /// Método para listar os medicos
        /// </summary>
        /// <returns>Lista de medicos</returns>
        public List<Medico> Listar()
        {
            using (ClevelandContext ctx = new ClevelandContext())
            {
                return ctx.Medicos.ToList();
            }

        }
    }
}
