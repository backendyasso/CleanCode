using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Subjects.Query.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Subjects.Query.Models
{
    public class GetSubjectListQuery : IRequest<Response<List<SubjectDto>>> { }
}
