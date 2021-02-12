using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.RigWellOperatorRecords;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RigWellOperatorRecordsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<RigWellOperatorRecord>>> List()
        {
            return await Mediator.Send(new ListRigWellOperatorRecord.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RigWellOperatorRecord>> Details(Guid id)
        {
            return await Mediator.Send(new DetailsRigWellOperatorRecord.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Create(RigWellOperatorRecord rigWellOperatorRecord)
        {
            return Ok(await Mediator.Send(new CreateRigWellOperatorRecord.Command { RigWellOperatorRecord = rigWellOperatorRecord }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, RigWellOperatorRecord rigWellOperatorRecord)
        {
            rigWellOperatorRecord.Id = id;
            return Ok(await Mediator.Send(new EditRigWellOperatorRecord.Command { RigWellOperatorRecord = rigWellOperatorRecord }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteRigWellOperatorRecord.Command { Id = id }));
        }
    }
}