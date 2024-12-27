using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TreversalCoreProje.CQRS.Handlers.DestinationHandlers;

namespace TreversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler getAllDestinationQueryHandler)
        {
            _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandler.Handle();
            return View(values);
        }
    }
}
