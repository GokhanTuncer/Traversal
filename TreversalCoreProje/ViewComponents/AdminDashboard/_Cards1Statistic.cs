using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Destination.Count();
            ViewBag.v2 = c.Users.Count();

            return View();
        }
    }
}
