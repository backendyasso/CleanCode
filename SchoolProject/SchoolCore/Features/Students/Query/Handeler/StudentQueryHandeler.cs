using AutoMapper;
using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Students.Query.Models;
using SchoolCore.Features.Students.Query.Result;
using SchoolService.Abstract;
using SchoolService.implementation;

public class StudentQueryHandler :
    IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>,
    IRequestHandler<GetStudentByIDQuery, Response<GetSingleStudentResponse>>
{
    private readonly IstudentService _service;  
    private readonly IMapper _mapper;
    private readonly ResponseHandler _responseHandler = new ResponseHandler();

    public StudentQueryHandler(IstudentService service, IMapper mapper)  
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<Response<List<GetStudentListResponse>>> Handle(
        GetStudentListQuery request,
        CancellationToken cancellationToken)
    {
        var studentsList = await _service.GetAllStudentsAsync();
        var studentListResponse = _mapper.Map<List<GetStudentListResponse>>(studentsList);
        return _responseHandler.Success(studentListResponse);  
    }

    public async Task<Response<GetSingleStudentResponse>> Handle(
        GetStudentByIDQuery request,
        CancellationToken cancellationToken)
    {
        var student = await _service.GetStudentByIdAsync(request.Id);

        if (student == null)
        {
            return _responseHandler.NotFound<GetSingleStudentResponse>("Student not found");
        }

        var studentResponse = _mapper.Map<GetSingleStudentResponse>(student);
        return _responseHandler.Success(studentResponse);  
    }
}