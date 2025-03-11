using Microsoft.AspNetCore.Mvc;
using stackfy_studio_back.Models;

namespace stackfy_studio_back.Controllers
{
    [ApiController]
    [Route("api/contato")]
    public class ContatoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ContatoModel contato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { mensagem = "Preencha todos os campos obrigatórios corretamente!" });
            }
            // Enviar e-mail
            return Ok(new { mensagem = $"Obrigado, {contato.Nome}! Recebemos a sua mensagem." });
        }
    }
}
