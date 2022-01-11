using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP_IT_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost("Add")]
        public ActionResult<string> Add([FromBody] AddClientVm model)
        {
            var result = _clientService.AddClient(model);
            return Ok(result);
        }
    }
}
