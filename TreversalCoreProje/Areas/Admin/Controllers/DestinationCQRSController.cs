using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TreversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TreversalCoreProje.CQRS.Queries.DestinationQueries;

namespace TreversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;
        private readonly GetDestinationByIDQueryHandler _getDestinationByIDQueryHandler;

        public DestinationCQRSController(GetDestinationByIDQueryHandler getDestinationByIDQueryHandler, GetAllDestinationQueryHandler getAllDestinationQueryHandler)
        {
            _getDestinationByIDQueryHandler = getDestinationByIDQueryHandler;
            _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
        }

      

        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIDQueryHandler.Handle(new GetDestinationByIDQuery(id));
            return View(values);
        }
    }
}
