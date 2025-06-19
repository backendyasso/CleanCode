using AutoMapper;
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
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, Response<string>>
    {
        private readonly IMapper _mapper;
        private readonly IstudentService _studentService;
        private readonly ResponseHandler _responseHandler;

        public UpdateStudentHandler(IMapper mapper, IstudentService studentService, ResponseHandler responseHandler)
        {
            _mapper = mapper;
            _studentService = studentService;
            _responseHandler = responseHandler;
        }

        public async Task<Response<string>> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAsync(request.Id);
            if (student == null)
                return _responseHandler.NotFound<string>("Student not found");

            student.Name = request.Name;
            student.Address = request.Address;
            student.Phone = request.Phone;
            student.DID = request.DepartmentId;

            await _studentService.UpdateAsync(student);
            return _responseHandler.Updated<string>("Student updated successfully");
        }
    }
}