using Microsoft.AspNetCore.SignalR;
using SignalRApi.Model;

namespace SignalRApi.Hubs
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
			await Clients.All.SendAsync("GetVisitList", _visitorService.GetVisitorChartList());
		}
	}
}
