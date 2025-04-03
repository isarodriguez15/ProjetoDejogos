using Microsoft.AspNetCore.Mvc;

namespace ProjetoDeJogos.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
