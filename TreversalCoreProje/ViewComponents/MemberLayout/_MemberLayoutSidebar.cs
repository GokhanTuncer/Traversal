using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace TreversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutSidebar :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
