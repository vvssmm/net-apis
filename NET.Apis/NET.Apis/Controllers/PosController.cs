using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using NET.Apis.Domain.Data.QueueService;
using NET.Apis.Domain.Pos;
using NET.Apis.SignalR.Hubs;

namespace NET.Apis.Controllers
{
    public class PosController : ControllerBase
    {
        private readonly IHubContext<PosHub,IPosSignalRClient> _hubContext;
        private readonly IListService _listService;
        public PosController(IHubContext<PosHub, IPosSignalRClient> hubContext, IListService service)
        {
            _hubContext = hubContext;
            _listService = service;
        }

        [HttpGet("pos-connections")]
        public IActionResult GetCurrentConnection()
        {
            var connectionIds = _listService.GetItems();
            return Ok(connectionIds);
        }
        //[HttpGet("pos-connections/send-all")]
        //public IActionResult SendAll()
        //{
        //    _hubContext.Clients.All.ReceiveMessage("test message");
        //    return Ok();
        //}

    }
}
