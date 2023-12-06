using Microsoft.AspNetCore.SignalR;
using NET.Apis.Domain.Data.QueueService;
using NET.Apis.Domain.Pos;

namespace NET.Apis.SignalR.Hubs
{
    public class PosHub:Hub
    {
        private readonly IListService _listService;
        public PosHub(IListService list)
        {
            _listService = list;
        }
        public override async Task OnConnectedAsync()
        {
            //var client = Clients.Client(Context.ConnectionId);
            await Clients.All.SendAsync("ReceiveMessage",$"{Context.ConnectionId} is joined");
            _listService.AddItem(Context.ConnectionId);
        }
    }
}
