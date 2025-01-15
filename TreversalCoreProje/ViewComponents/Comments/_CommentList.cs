using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace TreversalCoreProje.ViewComponents.Comments
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context=new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = context.Comment.Where(x=>x.DestinationID==id).Count();    
            var values = commentManager.TGetListCommentWithDestinationAndUser(id);             
            return View(values);
        }
    }
}
