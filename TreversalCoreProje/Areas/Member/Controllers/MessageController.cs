using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
