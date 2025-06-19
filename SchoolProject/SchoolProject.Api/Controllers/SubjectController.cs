using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolCore.Features.Subjects.Command.Models;
using SchoolCore.Features.Subjects.Query.Models;


namespace SchoolProject.Api.Controllers
{
    [Route(Router.subjectRouting.Prefix)]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Router.subjectRouting.List)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetSubjectListQuery());
            return Ok(result);
        }

        [HttpGet(Router.subjectRouting.GetById)]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetSubjectByIdQuery(id));
            return Ok(result);
        }

        [HttpPost(Router.subjectRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddSubjectCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut(Router.subjectRouting.Update)]
        public async Task<IActionResult> Update([FromBody] UpdateSubjectCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete(Router.subjectRouting.Delete)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteSubjectCommand(id));
            return Ok(result);
        }
    }
}
