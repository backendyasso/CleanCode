using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolCore.Features.Students.Command.Models;
using SchoolCore.Features.Students.Query.Models;
using SchoolProject.Api.Basics;

namespace SchoolProject.Api.Controllers
{

    [Route(Router.studentRouting.Prefix)]
    [ApiController]
    public class StudentController : AppControllerBase
    {
        public StudentController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet(Router.studentRouting.List)]
        public async Task<IActionResult> GetAllStudentList()
        {    //mediator send request that want to get all sendents to handeler the handeler direct deal with Service that has logic
            var Response =  await mediator.Send(new GetStudentListQuery());
            return Ok(Response);
        }

        [HttpGet(Router.studentRouting.GetById)]
        public async Task<IActionResult> GetStudentByID(int id)
        {    //mediator send request that want to get all sendents to handeler the handeler direct deal with Service that has logic
     
            return NewResult(await mediator.Send(new GetStudentByIDQuery(id)));
        }



        [HttpPost(Router.studentRouting.Create)]
        public async Task<IActionResult> Create(AddStudentCommand command)
        {    
            var Response = await mediator.Send(command);
            return Ok(Response);
        }
        [HttpPut(Router.studentRouting.Update)]
        public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentCommand command)
        {
            return NewResult(await mediator.Send(command));
        }

        [HttpDelete(Router.studentRouting.Delete)]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            return NewResult(await mediator.Send(new DeleteStudentCommand(id)));
        }


    }
}
