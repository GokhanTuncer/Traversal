using Microsoft.AspNetCore.SignalR;
using SignalRApi.Model;

namespace SignalRApi.Hubs
{
	public class VisitorHub : Hub
	{
		private readonly VisitotService _visitorService;

		public VisitorHub(VisitotService visitotService)
		{
			_visitorService = visitotService;
		}
		public async Task GetVisitorList()
		{
			await Clients.All.SendAsync("GetVisitList","_visitorService")
		}
	}
}
