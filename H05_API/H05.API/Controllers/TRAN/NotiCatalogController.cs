using Common;
using H05.API.AppCode.Enum;
using H05.API.AppCode.Extensions;
using H05.BUSINESS.Dtos.MD;
using H05.BUSINESS.Dtos.TRAN;
using H05.BUSINESS.Filter.MD;
using H05.BUSINESS.Services.MD;
using H05.BUSINESS.Services.TRAN;
using H05.CORE.Entities.TRAN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H05.API.Controllers.TRAN
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotiCatalogController(INotiCatalogService service) : ControllerBase
    {
        public readonly INotiCatalogService _service = service;

        [HttpGet("Search")]
        public async Task<IActionResult> Search([FromQuery] BaseFilter filter)
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
                transferObject.GetMessage("0001", _service);
            }
            return Ok(transferObject);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var transferObject = new TransferObject();
            var result = await _service.GetAll();
            if (_service.Status)
            {
                transferObject.Data = result;
            }
            else
            {
                transferObject.Status = false;
                transferObject.MessageObject.MessageType = MessageType.Error;
                transferObject.GetMessage("0001", _service);
            }
            return Ok(transferObject);
        }
        [HttpGet("GetByQmnum/{qmnum}")]
        public async Task<IActionResult> GetByQmnum([FromRoute] string qmnum)
        {
            var transferObject = new TransferObject();
            var result = await _service.GetByQmnum(qmnum);
            if (_service.Status)
            {
                transferObject.Data = result;
            }
            else
            {
                transferObject.Status = false;
                transferObject.MessageObject.MessageType = MessageType.Error;
                transferObject.GetMessage("0001", _service);
            }
            return Ok(transferObject);
        }
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] NotiCatalogDto time)
        {
            var transferObject = new TransferObject();
            var result = await _service.Add(time);
            if (_service.Status)
            {
                transferObject.Data = result;
                transferObject.Status = true;
                transferObject.MessageObject.MessageType = MessageType.Success;
                transferObject.GetMessage("0100", _service);
            }
            else
            {
                transferObject.Status = false;
                transferObject.MessageObject.MessageType = MessageType.Error;
                transferObject.GetMessage("0101", _service);
            }
            return Ok(transferObject);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] List<TblTranNotiCatalog> time)
        {
            var transferObject = new TransferObject();
            await _service.UpdateCatalog(time);
            if (_service.Status)
            {
                transferObject.Status = true;
                transferObject.MessageObject.MessageType = MessageType.Success;
                transferObject.GetMessage("0103", _service);
            }
            else
            {
                transferObject.Status = false;
                transferObject.MessageObject.MessageType = MessageType.Error;
                transferObject.GetMessage("0104", _service);
            }
            return Ok(transferObject);
        }
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
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
