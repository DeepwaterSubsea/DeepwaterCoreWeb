using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.RigContractors;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RigContractorsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<RigContractor>>> List()
        {
            return await Mediator.Send(new ListRigContractor.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RigContractor>> Details(Guid id)
        {
            return await Mediator.Send(new DetailsRigContractor.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Create(RigContractor rigContractor)
        {
            return Ok(await Mediator.Send(new CreateRigContractor.Command { RigContractor = rigContractor }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, RigContractor rigContractor)
        {
            rigContractor.Id = id;
            return Ok(await Mediator.Send(new EditRigContractor.Command { RigContractor = rigContractor }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteRigContractor.Command { Id = id }));
        }
    }
}