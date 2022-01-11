using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.RaportType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP_IT_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class RaportTypeController : ControllerBase
    {
        private readonly IRaportTypeService _raportTypeService;

        public RaportTypeController(IRaportTypeService raportTypeService)
        {
            _raportTypeService = raportTypeService;
        }

        [HttpPost("Add")]
        public ActionResult<string> Add([FromBody] AddRaportTypeVm model)
        {
            var result = _raportTypeService.AddRaportType(model);
            return Ok(result);
        }
    }
}
