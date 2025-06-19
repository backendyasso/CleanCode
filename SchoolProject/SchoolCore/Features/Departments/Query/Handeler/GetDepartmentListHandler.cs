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
    public class GetDepartmentListHandler : IRequestHandler<GetDepartmentListQuery, Response<List<Department>>>
    {
        private readonly IDepartmentService _departmentService;
        private readonly ResponseHandler _responseHandler;

        public GetDepartmentListHandler(IDepartmentService departmentService, ResponseHandler responseHandler)
        {
            _departmentService = departmentService;
            _responseHandler = responseHandler;
        }

        public async Task<Response<List<Department>>> Handle(GetDepartmentListQuery request, CancellationToken cancellationToken)
        {
            var list = await _departmentService.GetAllAsync();
            return _responseHandler.Success(list);
        }
    }
}
