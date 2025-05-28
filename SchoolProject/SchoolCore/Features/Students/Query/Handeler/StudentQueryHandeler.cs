using AutoMapper;
using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Students.Query.Models;
using SchoolCore.Features.Students.Query.Result;
using SchoolService.Abstract;

public class StudentQueryHandeler : ResponseHandler, IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>
{
    private readonly IstudentService _service;
    private readonly IMapper _mapper;

    public StudentQueryHandeler(IstudentService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
    {
        var studentsList = await _service.GetAllStudentsAsync();
        var studentListResponse = _mapper.Map<List<GetStudentListResponse>>(studentsList);
        return Success(studentListResponse);
    }
}