using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolCore.Features.Students.Query.Models;

namespace SchoolProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator mediator;
        public StudentController(IMediator mediator) => this.mediator = mediator;


        [HttpGet("/Student/List")]
        public async Task<IActionResult> GetAllStudentList()
        {    //mediator send request that want to get all sendents to handeler the handeler direct deal with Service that has logic
            var Response =  await mediator.Send(new GetStudentListQuery());
            return Ok(Response);
        }

    }
}
