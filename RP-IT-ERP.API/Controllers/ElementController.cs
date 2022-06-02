using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP_IT_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ElementController : ControllerBase
    {
        private readonly IElementService _elementService;

        public ElementController(IElementService elementService)
        {
            _elementService = elementService;
        }

        [HttpPost("Add")]
        public ActionResult<string> Add([FromBody] AddElementVm model)
        {
            var result = _elementService.AddElement(model);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(int id)
        {
            _elementService.DeleteElement(id);
            return Ok();
        }

        [HttpGet("GetAll")]
        public ActionResult<ListGetElementsVm> GetAll()
        {
            var result = _elementService.GetAllElements();
            return Ok(result);
        }

        [HttpPut("Update")]
        public ActionResult Update([FromBody] UpdateElementVm model)
        {
            _elementService.UpdateElement(model);
            return Ok();
        }

        [HttpGet("Get")]
        public ActionResult<GetElementVm> Get(int id)
        {
            var result = _elementService.GetElement(id);
            return Ok(result);
        }
    }
}
