using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Students.Command.Models;
using SchoolService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Students.Command.Handeler
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, Response<string>>
    {
        private readonly IstudentService _studentService;
        private readonly ResponseHandler _responseHandler;

        public DeleteStudentHandler(IstudentService studentService, ResponseHandler responseHandler)
        {
            _studentService = studentService;
            _responseHandler = responseHandler;
        }

        public async Task<Response<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAsync(request.Id);
            if (student == null)
                return _responseHandler.NotFound<string>("Student not found");

            await _studentService.DeleteAsync(student);
            return _responseHandler.Deleted<string>();
        }
    }
}

