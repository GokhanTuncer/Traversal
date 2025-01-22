using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutNavbar :ViewComponent
    {
        public IViewComponentResult Invoke()
        {  return View(); }
    }
}
