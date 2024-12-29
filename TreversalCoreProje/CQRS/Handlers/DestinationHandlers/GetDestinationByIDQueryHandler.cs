using DataAccessLayer.Concrete;
using TreversalCoreProje.CQRS.Queries.DestinationQueries;
using TreversalCoreProje.CQRS.Results.DestinationResults;

namespace TreversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destination.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                Destinationid = values.DestinationID,
                City = values.City,
                Daynight = values.DayNight,
                Price = values.Price
            };
        }
    }
}
