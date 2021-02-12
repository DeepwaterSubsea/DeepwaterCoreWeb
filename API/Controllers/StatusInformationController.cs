using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.StatusInfo;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusInformationController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<StatusInformation>>> List()
        {
            return await Mediator.Send(new ListStatusInformation.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StatusInformation>> Details(Guid id)
        {
            return await Mediator.Send(new DetailsStatusInformation.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Create(StatusInformation statusInformation)
        {
            return Ok(await Mediator.Send(new CreateStatusInformation.Command { StatusInformation = statusInformation }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(Guid id, StatusInformation statusInformation)
        {
            statusInformation.Id = id;
            return Ok(await Mediator.Send(new EditStatusInformation.Command { StatusInformation = statusInformation }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteStatusInformation.Command { Id = id }));
        }
    }
}