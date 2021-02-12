using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.RigOperators;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RigOperatorsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<RigOperator>>> List()
        {
            return await Mediator.Send(new ListRigOperator.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RigOperator>> Details(Guid id)
        {
            return await Mediator.Send(new DetailsRigOperator.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Create(RigOperator rigOperator)
        {
            return Ok(await Mediator.Send(new CreateRigOperator.Command { RigOperator = rigOperator }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, RigOperator rigOperator)
        {
            rigOperator.Id = id;
            return Ok(await Mediator.Send(new EditRigOperator.Command { RigOperator = rigOperator }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteRigOperator.Command { Id = id }));
        }
    }
}