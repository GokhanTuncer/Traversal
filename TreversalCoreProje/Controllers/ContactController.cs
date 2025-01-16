using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactUsManager commentManager = new ContactUsManager(new EfContactUsDal());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
		[HttpPost]
		public IActionResult Index()
		{
			return View();
		}
	}
}
