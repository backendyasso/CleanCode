using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolCore.Features.Students.Command.Models;
using SchoolCore.Features.Students.Query.Models;
using SchoolData.AppMetaData;
using SchoolProject.Api.Basics;

namespace SchoolProject.Api.Controllers
{
   
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
    }
}
