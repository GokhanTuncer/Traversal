using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.Controllers
{
	public class AboutController : Controller
	{
		private readonly IGuideService _guideService;

		public AboutController(IGuideService guideService)
		{
			_guideService = guideService;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
