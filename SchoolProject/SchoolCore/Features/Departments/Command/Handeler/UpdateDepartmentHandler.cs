using AutoMapper;
using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Departments.Command.Models;
using SchoolService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Departments.Command.Handeler
{
    public class UpdateDepartmentHandler : IRequestHandler<UpdateDepartmentCommand, Response<string>>
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentService _departmentService;
        private readonly ResponseHandler _responseHandler;

        public UpdateDepartmentHandler(IMapper mapper, IDepartmentService departmentService, ResponseHandler responseHandler)
        {
            _mapper = mapper;
            _departmentService = departmentService;
            _responseHandler = responseHandler;
        }

        public async Task<Response<string>> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _departmentService.GetByIdAsync(request.Id);
            if (department == null)
                return _responseHandler.NotFound<string>("Department not found");

            department.DName = request.DName;
            await _departmentService.UpdateAsync(department);

            return _responseHandler.Updated<string>("Department updated successfully");
        }
    }
}
