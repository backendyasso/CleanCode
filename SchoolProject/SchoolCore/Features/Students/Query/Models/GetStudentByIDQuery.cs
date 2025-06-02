
using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Students.Query.Result;

namespace SchoolCore.Features.Students.Query.Models
{
    public class GetStudentByIDQuery : IRequest<Response<GetSingleStudentResponse>>
    {
        public int Id { get; set; }
        public GetStudentByIDQuery() { }

        public GetStudentByIDQuery(int id)
        {
            Id = id;
        }
    }
}