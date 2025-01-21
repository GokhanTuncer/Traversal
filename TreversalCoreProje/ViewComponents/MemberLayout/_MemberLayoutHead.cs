using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutHead : ViewComponent
    {
        public IViewComponentResult Invoke()
            { return View(); }
    }
}
