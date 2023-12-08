using Microsoft.AspNetCore.SignalR;
using NET.Apis.Domain.Data.QueueService;
using NET.Apis.Domain.Pos;

namespace NET.Apis.SignalR.Hubs
{
    public sealed class PosHub:Hub<IPosSignalRClient>
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.ReceiveMessage("menvs", "hí anh em");
        }
        public Task SendMessage(string user, string message)
        {
            return Clients.All.ReceiveMessage(user, message);
        }
    }
}
