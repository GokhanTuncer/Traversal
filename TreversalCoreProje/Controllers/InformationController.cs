using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.Controllers
{
    
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
