using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.Controllers
{
	public class DestinationController : Controller
	{
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
		{
            var values = destinationManager.TGetList();
            return View(values);
        }

        //Tur Detayı oluşturma
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i = id;
            var values=destinationManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
	}
}
