﻿using Common;
using H05.API.AppCode.Enum;
using H05.API.AppCode.Extensions;
using H05.BUSINESS.Dtos.AD;
using H05.BUSINESS.Services.AD;
using Microsoft.AspNetCore.Mvc;

namespace H05.API.Controllers.AD
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemTraceController(ISystemTraceService service) : ControllerBase
    {
        private readonly ISystemTraceService _service = service;

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] SystemTraceCreateUpdateDto model)
        {
            var transferObject = new TransferObject();
            var result = await _service.Add(model);
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

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] SystemTraceCreateUpdateDto model)
        {
            var transferObject = new TransferObject();
            await _service.Update(model);
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

        [HttpDelete("Delete/{code}")]
        public async Task<IActionResult> Delete([FromRoute] string code)
        {
            var transferObject = new TransferObject();
            await _service.Delete(code);
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
