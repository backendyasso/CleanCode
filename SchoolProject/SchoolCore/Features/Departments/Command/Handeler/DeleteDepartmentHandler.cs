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
    public class DeleteDepartmentHandler : IRequestHandler<DeleteDepartmentCommand, Response<string>>
    {
        private readonly IDepartmentService _departmentService;
        private readonly ResponseHandler _responseHandler;

        public DeleteDepartmentHandler(IDepartmentService departmentService, ResponseHandler responseHandler)
        {
            _departmentService = departmentService;
            _responseHandler = responseHandler;
        }

        public async Task<Response<string>> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _departmentService.GetByIdAsync(request.Id);
            if (department == null)
                return _responseHandler.NotFound<string>("Department not found");

            await _departmentService.DeleteAsync(department);
            return _responseHandler.Deleted<string>();
        }
    }
}
