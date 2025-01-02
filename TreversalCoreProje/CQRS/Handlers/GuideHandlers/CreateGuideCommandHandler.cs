using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using TreversalCoreProje.CQRS.Commands.GuideCommands;

namespace TreversalCoreProje.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    { 
        private readonly Context _context;
        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guide.Add(new Guide
            {
                Name = request.Name,
                Description = request.Description,
                Status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }

        Task IRequestHandler<CreateGuideCommand>.Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
