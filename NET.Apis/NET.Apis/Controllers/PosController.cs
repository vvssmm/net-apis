using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using NET.Apis.Domain.Pos;
using NET.Apis.SignalR.Hubs;

namespace NET.Apis.Controllers
{
    public class PosController : ControllerBase
    {
        private readonly IHubContext<PosHub,IPosSignalRClient> _hubContext;
        public PosController(IHubContext<PosHub, IPosSignalRClient> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpGet("pos-connections")]
        public IActionResult GetCurrentConnection()
        {
            return Ok();
        }
        //[HttpGet("pos-connections/send-all")]
        //public IActionResult SendAll()
        //{
        //    _hubContext.Clients.All.ReceiveMessage("test message");
        //    return Ok();
        //}

    }
}
