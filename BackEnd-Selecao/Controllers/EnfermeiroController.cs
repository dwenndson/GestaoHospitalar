using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd_Selecao.DataBase;
using BackEnd_Selecao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Selecao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnfermeiroController : ControllerBase
    {
        private readonly Contexto _contexto;

        public EnfermeiroController(Contexto contexto) => _contexto = contexto;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Enfermeiro>>> GetAll()
        {
            return await _contexto.Enfermeiros.ToListAsync();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetById([FromRoute] string Cpf) 
        {

            return new NotFoundResult();
        }
        
    }
}
