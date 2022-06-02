using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP_IT_ERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpPost("Add")]
        public ActionResult<string> Add([FromBody] AddWarehouseItemVm model)
        {
            var result = _warehouseService.AddWarehouseItem(model);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(int id)
        {
            _warehouseService.DeleteWarehouseItem(id);
            return Ok();
        }

        [HttpGet("GetAll")]
        public ActionResult<ListGetWarehouseItemsVm> GetAll()
        {
            var result = _warehouseService.GetAllWarehouseItems();
            return Ok(result);
        }

        [HttpPut("Update")]
        public ActionResult Update([FromBody] UpdateWarehouseItemsVm model)
        {
            _warehouseService.UpdateWarehouseItem(model);
            return Ok();
        }
    }
}
