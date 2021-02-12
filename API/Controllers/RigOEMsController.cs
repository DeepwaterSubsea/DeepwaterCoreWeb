using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.RigOEMs;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RigOEMsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<RigOriginalEquipmentManufacturer>>> List()
        {
            return await Mediator.Send(new ListRigOEM.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RigOriginalEquipmentManufacturer>> Details(Guid id)
        {
            return await Mediator.Send(new DetailsRigOEM.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Create(RigOriginalEquipmentManufacturer rigOEM)
        {
            return Ok(await Mediator.Send(new CreateRigOEM.Command { RigOEM = rigOEM }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, RigOriginalEquipmentManufacturer rigOEM)
        {
            rigOEM.Id = id;
            return Ok(await Mediator.Send(new EditRigOEM.Command { RigOEM = rigOEM }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteRigOEM.Command { Id = id }));
        }
    }
}