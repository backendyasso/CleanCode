using MediatR;
using SchoolCore.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Departments.Command.Models
{
    public class AddDepartmentCommand : IRequest<Response<string>>
    {
        public string DName { get; set; }
    }
}
