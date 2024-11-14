using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.ViewComponents.Comments
{
    public class _CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
