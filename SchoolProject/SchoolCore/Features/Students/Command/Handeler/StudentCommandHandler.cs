using AutoMapper;
using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Students.Command.Models;
using SchoolService.Abstract;

public class AddStudentHandler : IRequestHandler<AddStudentCommand, Response<string>>
{
    private readonly IMapper _mapper;
    private readonly IstudentService _studentService;
    private readonly ResponseHandler _responseHandler;

    public AddStudentHandler(IMapper mapper, IstudentService studentService, ResponseHandler responseHandler)
    {
        _mapper = mapper;
        _studentService = studentService;
        _responseHandler = responseHandler;
    }

    public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {
        var Student = _mapper.Map<SchoolData.Entities.Student>(request);
        var AddResult = await _studentService.AddAsync(Student);

        if (AddResult == "Exist")
            return _responseHandler.UnprocessableEntity<string>("Student Already Exist");

        if (AddResult == "Student added successfully")
            return _responseHandler.Created("Student added successfully");

        return _responseHandler.BadRequest<string>("Failed to add Student");
    }
}
