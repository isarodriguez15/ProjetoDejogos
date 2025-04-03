using Microsoft.AspNetCore.Mvc;

namespace ProjetoDeJogos.Controllers
{
    public class JogoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
