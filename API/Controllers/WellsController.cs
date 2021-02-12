using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Wells;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WellsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Well>>> List()
        {
            return await Mediator.Send(new ListWell.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Well>> Details(Guid id)
        {
            return await Mediator.Send(new DetailsWell.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Create(Well well)
        {
            return Ok(await Mediator.Send(new CreateWell.Command { Well = well }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, Well well)
        {
            well.Id = id;
            return Ok(await Mediator.Send(new EditWell.Command { Well = well }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteWell.Command { Id = id }));
        }
    }
}