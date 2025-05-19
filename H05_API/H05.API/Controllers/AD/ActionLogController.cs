using Common;
using H05.API.AppCode.Enum;
using H05.API.AppCode.Extensions;
using H05.BUSINESS.Filter.AD;
using H05.BUSINESS.Services.AD;
using Microsoft.AspNetCore.Mvc;

namespace H05.API.Controllers.AD
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActionLogController(IActionLogService service) : ControllerBase
    {
        private readonly IActionLogService _service = service;

        [HttpGet("Search")]
        public async Task<IActionResult> Search([FromQuery] ActionLogFilter filter)
        {
            var transferObject = new TransferObject();
            var result = await _service.Search(filter);
            if (_service.Status)
            {
                transferObject.Data = result;
            }
            else
            {
                transferObject.Status = false;
                transferObject.MessageObject.MessageType = MessageType.Error;
                transferObject.GetMessage("2000", _service);
            }
            return Ok(transferObject);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var transferObject = new TransferObject();
            await _service.Delete(id);
            if (_service.Status)
            {
                transferObject.Status = true;
                transferObject.MessageObject.MessageType = MessageType.Success;
                transferObject.GetMessage("0105", _service);
            }
            else
            {
                transferObject.Status = false;
                transferObject.MessageObject.MessageType = MessageType.Error;
                transferObject.GetMessage("0106", _service);
            }
            return Ok(transferObject);
        }
    }
}
