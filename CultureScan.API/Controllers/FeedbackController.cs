using CultureScan.Domain.Perguntas;
using Microsoft.AspNetCore.Mvc;

namespace CultureScan.API.Controllers
{
    public class FeedbackController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PerguntaDto>> GetQuestions()
            => Ok(Perguntas);
    }
}
