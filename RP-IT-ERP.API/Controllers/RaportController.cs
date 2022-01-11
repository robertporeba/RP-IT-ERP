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
    }
}
