using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Departments.Query.Models;
using SchoolData.Entities;
using SchoolService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Departments.Query.Handeler
{
    public class GetDepartmentByIdHandler : IRequestHandler<GetDepartmentByIdQuery, Response<Department>>
    {
        private readonly IDepartmentService _departmentService;
        private readonly ResponseHandler _responseHandler;

        public GetDepartmentByIdHandler(IDepartmentService departmentService, ResponseHandler responseHandler)
        {
            _departmentService = departmentService;
            _responseHandler = responseHandler;
        }

        public async Task<Response<Department>> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var department = await _departmentService.GetByIdAsync(request.Id);
            if (department == null)
                return _responseHandler.NotFound<Department>("Department not found");

            return _responseHandler.Success(department);
        }
    }
}
