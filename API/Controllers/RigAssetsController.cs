using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.RigAssets;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RigAssetsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<RigAsset>>> List()
        {
            return await Mediator.Send(new ListRigAsset.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RigAsset>> Details(Guid id)
        {
            return await Mediator.Send(new DetailsRigAsset.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Create(RigAsset rigAsset)
        {
            return Ok(await Mediator.Send(new CreateRigAsset.Command { RigAsset = rigAsset }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, RigAsset rigAsset)
        {
            rigAsset.Id = id;
            return Ok(await Mediator.Send(new EditRigAsset.Command { RigAsset = rigAsset }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteRigAsset.Command { Id = id }));
        }
    }
}