using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolCore.Features.Departments.Command.Models;
using SchoolCore.Features.Departments.Query.Models;
using SchoolProject.Api.Basics;

namespace SchoolProject.Api.Controllers
{
    [Route(Router.departmentRouting.Prefix)]
    [ApiController]
    public class DepartmentController : AppControllerBase
    {
        private readonly IMediator mediator;

        public DepartmentController(IMediator mediator) : base(mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet(Router.departmentRouting.List)]
        public async Task<IActionResult> GetAllDepartments()
            => NewResult(await mediator.Send(new GetDepartmentListQuery()));

        [HttpGet(Router.departmentRouting.GetById)]
        public async Task<IActionResult> GetDepartmentById(int id)
            => NewResult(await mediator.Send(new GetDepartmentByIdQuery(id)));

        [HttpPost(Router.departmentRouting.Create)]
        public async Task<IActionResult> CreateDepartment([FromBody] AddDepartmentCommand command)
            => NewResult(await mediator.Send(command));

        [HttpPut(Router.departmentRouting.Update)]
        public async Task<IActionResult> UpdateDepartment([FromBody] UpdateDepartmentCommand command)
            => NewResult(await mediator.Send(command));

        [HttpDelete(Router.departmentRouting.Delete)]
        public async Task<IActionResult> DeleteDepartment(int id)
            => NewResult(await mediator.Send(new DeleteDepartmentCommand(id)));
    }
}
