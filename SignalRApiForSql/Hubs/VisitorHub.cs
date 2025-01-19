using Microsoft.AspNetCore.SignalR;
using SignalRApiForSql.Models;

namespace SignalRApiForSql.Hubs
{
    public class VisitorHub : Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHub(VisitorService visitotService)
        {
            _visitorService = visitotService;
        }
        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("ReceiveVisitorList", _visitorService.GetVisitorChartList());
        }
    }
}
