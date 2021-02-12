using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Rigs;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RigsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Rig>>> List()
        {
            return await Mediator.Send(new ListRig.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Rig>> Details(Guid id)
        {
            return await Mediator.Send(new DetailsRig.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Create(Rig rig)
        {
            return Ok(await Mediator.Send(new CreateRig.Command { Rig = rig }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, Rig rig)
        {
            rig.Id = id;
            return Ok(await Mediator.Send(new EditRig.Command { Rig = rig }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteRig.Command { Id = id }));
        }
    }
}