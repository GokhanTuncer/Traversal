using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
