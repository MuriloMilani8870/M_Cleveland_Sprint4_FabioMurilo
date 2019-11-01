using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_Cleveland_FabioMurilo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace M_Cleveland_FabioMurilo.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class MedicosController : ControllerBase
    {
        MedicoRepository MedicosRepository = new MedicoRepository();

        /// <summary>
        /// Método que lista todos os Medicos
        /// </summary>
        /// <returns>Lista de Medicos</returns>
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(MedicosRepository.Listar());
        }
    }
}