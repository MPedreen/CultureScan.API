using CultureScan.Domain.Perguntas;
using Microsoft.AspNetCore.Mvc;

namespace CultureScan.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PerguntaController : ControllerBase
{
    [HttpGet("{pergunta}")]
    public ActionResult<IEnumerable<PerguntaDto>> ObterPorCategoria(TipoCategoria categoria)
    {
        var perguntas = categoria switch
        {
            TipoCategoria.Carreira => new Carreira().ObterPerguntas(),
            TipoCategoria.Chefia => new Chefia().ObterPerguntas(),
            TipoCategoria.Comunicacao => new Comunicacao().ObterPerguntas(),
            TipoCategoria.Corporativo => new Corporativo().ObterPerguntas(),
            TipoCategoria.Processo => new Processo().ObterPerguntas(),
            TipoCategoria.Remuneracao => new Remuneracao().ObterPerguntas(),
            _ => null
        };

        return Ok(perguntas);
    }
}
