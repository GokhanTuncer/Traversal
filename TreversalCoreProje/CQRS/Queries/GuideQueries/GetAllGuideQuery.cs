using MediatR;
using TreversalCoreProje.CQRS.Results.GuideResults;

namespace TreversalCoreProje.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery :IRequest<List<GetAllGuideQueryResult>>
    {

    }
}
