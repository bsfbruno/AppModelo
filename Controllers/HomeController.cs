using Dev.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dev.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        private IPedidoRepository _pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
