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

        [HttpDelete("Delete")]
        public ActionResult Delete(int id)
        {
            _clientService.DeleteClient(id);
            return Ok();
        }

        [HttpGet("GetAll")]
        public ActionResult<ListGetClientsVm> GetAll()
        {
            var result = _clientService.GetAllClients();
            return Ok(result);
        }

        [HttpPut("Update")]
        public ActionResult Update([FromBody] UpdateClientVm model)
        {
            _clientService.UpdateClient(model);
            return Ok();
        }

        [HttpGet("Get")]
        public ActionResult<GetClientVm> Get(int id)
        {
            var result = _clientService.GetClient(id);
            return Ok(result);
        }
    }
}
