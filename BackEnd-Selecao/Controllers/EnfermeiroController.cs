using BackEnd_Selecao.Models;
using BackEnd_Selecao.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace BackEnd_Selecao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnfermeiroController : ControllerBase
    {
        private readonly IEnfermeirosRepository _enfermeirosRepository;

        public EnfermeiroController(IEnfermeirosRepository enfermeirosRepository)
        {
            _enfermeirosRepository = enfermeirosRepository;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            return new ObjectResult(_enfermeirosRepository.GetAll());
        }

        [HttpGet("{id}", Name ="GetByCpf")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByCpf([FromRoute] string Cpf) 
        {
            var cpf = _enfermeirosRepository.GetByCpf(Cpf);
            if (cpf == null)
            {
                return new BadRequestResult();
            }
            return new OkObjectResult(cpf);
        }
        
        [HttpPost(Name ="PostEnfermeiro")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Save([FromBody]Enfermeiro enfermeiro)
        {
            Enfermeiro SaveEnfermero = _enfermeirosRepository.Save(enfermeiro);
            if (ModelState.IsValid)
            {
                _enfermeirosRepository.Save(SaveEnfermero);
                return new OkObjectResult(SaveEnfermero);
            }
            return new BadRequestObjectResult(SaveEnfermero);
        }

    }
}
