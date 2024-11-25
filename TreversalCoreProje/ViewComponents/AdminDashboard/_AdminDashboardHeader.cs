using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
