using DataAccessLayer.Concrete;
using MediatR;
using NuGet.Protocol.Plugins;
using TreversalCoreProje.CQRS.Queries.GuideQueries;
using TreversalCoreProje.CQRS.Results.GuideResults;

namespace TreversalCoreProje.CQRS.Handlers.GuideHandlers
{
  
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
    {  
        private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guide.FindAsync(request.Id);
            return new GetGuideByIDQueryResult
            {
                GuideID = values.GuideID,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
