using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Students.Query.Result;
using SchoolData.Entities;

namespace SchoolCore.Features.Students.Query.Models
{
    public class GetStudentListQuery : IRequest<Response<List<GetStudentListResponse>>>
    {
    }
}
