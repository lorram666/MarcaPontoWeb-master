using Microsoft.AspNetCore.Mvc;

namespace MarcaPonto.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
