using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.ViewComponents.AdminDashboard
{
    public class _DashboardBanner :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
