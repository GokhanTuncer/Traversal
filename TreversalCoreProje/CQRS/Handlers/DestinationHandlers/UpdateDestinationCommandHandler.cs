using DataAccessLayer.Concrete;
using TreversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TreversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;
        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destination.Find(command.Destinationid);
            values.City = command.City;
            values.DayNight = command.Daynight;
            values.Price = command.Price;
            _context.SaveChanges();
        }
    }
}
