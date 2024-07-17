using Microsoft.AspNetCore.Mvc;

namespace NLayer.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
