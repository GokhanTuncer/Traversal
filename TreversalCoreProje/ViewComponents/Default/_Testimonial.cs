using Microsoft.AspNetCore.Mvc;

namespace TreversalCoreProje.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
