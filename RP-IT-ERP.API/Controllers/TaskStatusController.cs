using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.TaskStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP_IT_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TaskStatusController : ControllerBase
    {
        private readonly ITaskStatusService _taskStatusService;

        public TaskStatusController(ITaskStatusService taskStatusService)
        {
            _taskStatusService = taskStatusService;
        }

        [HttpPost("Add")]
        public ActionResult<string> Add([FromBody] AddTaskStatusVm model)
        {
            var result = _taskStatusService.AddTaskStatus(model);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(int id)
        {
            _taskStatusService.DeleteTaskStatus(id);
            return Ok();
        }

        [HttpGet("GetAll")]
        public ActionResult<ListGetTaskStatuesVm> GetAll()
        {
            var result = _taskStatusService.GetAlltaskStatuses();
            return Ok(result);
        }
    }
}
