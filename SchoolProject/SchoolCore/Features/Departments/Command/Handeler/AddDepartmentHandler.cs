using AutoMapper;
using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Departments.Command.Models;
using SchoolData.Entities;
using SchoolService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Departments.Command.Handeler
{
    public class AddDepartmentHandler : IRequestHandler<AddDepartmentCommand, Response<string>>
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentService _departmentService;
        private readonly ResponseHandler _responseHandler;

        public AddDepartmentHandler(IMapper mapper, IDepartmentService departmentService, ResponseHandler responseHandler)
        {
            _mapper = mapper;
            _departmentService = departmentService;
            _responseHandler = responseHandler;
        }

        public async Task<Response<string>> Handle(AddDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = _mapper.Map<Department>(request);
            var result = await _departmentService.AddAsync(department);

            if (result == "Already exist")
                return _responseHandler.UnprocessableEntity<string>("Department already exists");

            return _responseHandler.Created("Department added successfully");
        }
    }
}
