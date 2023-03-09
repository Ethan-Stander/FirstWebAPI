using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
