using MediatR;
using SchoolCore.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Subjects.Command.Models
{
    public class AddSubjectCommand : IRequest<Response<string>>
    {
        public string SubjectName { get; set; }
        public DateTime Period { get; set; }
    }
}
