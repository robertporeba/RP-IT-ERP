using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP_IT_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost("Add")]
        public ActionResult<string> Add([FromBody] AddTaskVm model)
        {
            var result = _taskService.AddTask(model);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(int id)
        {
            _taskService.DeleteTask(id);
            return Ok();
        }

        [HttpGet("GetAll")]
        public ActionResult<ListGetTasksVm> GetAll()
        {
            var result = _taskService.GetAllTasks();
            return Ok(result);
        }

        [HttpPut("Update")]
        public ActionResult Update([FromBody] UpdateTaskVm model)
        {
            _taskService.UpdateTask(model);
            return Ok();
        }

        [HttpGet("Get")]
        public ActionResult<GetTaskVm> Get(int id)
        {
            var result = _taskService.GetTask(id);
            return Ok(result);
        }
    }
}
