using Microsoft.AspNetCore.Mvc;

namespace NLayer.Web.Controllers
{
    public class SavedCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
