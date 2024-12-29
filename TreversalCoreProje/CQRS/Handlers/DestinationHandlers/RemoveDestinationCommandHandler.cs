using DataAccessLayer.Concrete;
using TreversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TreversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;
        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destination.Find(command.Id);
            _context.Destination.Remove(values);
            _context.SaveChanges();
        }
    }
}
