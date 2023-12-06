using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using NET.Apis.Domain.Data.QueueService;
using NET.Apis.Domain.Pos;
using NET.Apis.SignalR.Hubs;

namespace NET.Apis.Controllers
{
    public class PosController : ControllerBase
    {
        private readonly IHubContext<PosHub> _hubContext;
        private readonly IListService _listService;
        public PosController(IHubContext<PosHub> hubContext, IListService service)
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
        [HttpGet]
        public IActionResult SendMessage(string message)
        {
            //_hubContext.Clients.All.ReceiveMessage(message);
            return NoContent();
        }
    }
}
