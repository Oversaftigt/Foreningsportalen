using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
