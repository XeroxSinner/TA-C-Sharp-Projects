using Microsoft.AspNetCore.Mvc;

namespace ASPDemo1.Controllers
{
    public class Products : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
