using MediatR;
using SchoolCore.Basics;
using SchoolData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Departments.Query.Models
{
    public class GetDepartmentListQuery : IRequest<Response<List<Department>>>
    {
    }
}
