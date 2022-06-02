using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.Raport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP_IT_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class RaportController : ControllerBase
    {
        private readonly IRaportService _raportService;

        public RaportController(IRaportService raportService)
        {
            _raportService = raportService;
        }

        [HttpPost("Add")]
        public ActionResult<string> Add([FromBody] AddRaportVm model)
        {
            var result = _raportService.AddRaport(model);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(int id)
        {
            _raportService.DeleteRaport(id);
            return Ok();
        }

        [HttpGet("GetAll")]
        public ActionResult<ListGetRaportsVm> GetAll()
        {
            var result = _raportService.GetAllRaports();
            return Ok(result);
        }

        [HttpGet("Get")]
        public ActionResult<GetRaportVm> Get(int id)
        {
            var result = _raportService.GetRaport(id);
            return Ok(result);
        }
    }
}
