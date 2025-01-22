using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutHeaderContent : ViewComponent
    {
        public IViewComponentResult Invoke()
            { return View(); }
    }
}
