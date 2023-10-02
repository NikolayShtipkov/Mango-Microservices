using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
