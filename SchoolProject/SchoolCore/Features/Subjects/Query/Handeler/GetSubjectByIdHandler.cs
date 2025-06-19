using AutoMapper;
using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Subjects.Query.Models;
using SchoolCore.Features.Subjects.Query.Result;
using SchoolService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Subjects.Query.Handeler
{
    public class GetSubjectByIdHandler : IRequestHandler<GetSubjectByIdQuery, Response<SubjectDto>>
    {
        private readonly ISubjectService _subjectService;
        private readonly IMapper _mapper;
        private readonly ResponseHandler _responseHandler;

        public GetSubjectByIdHandler(ISubjectService subjectService, IMapper mapper, ResponseHandler responseHandler)
        {
            _subjectService = subjectService;
            _mapper = mapper;
            _responseHandler = responseHandler;
        }

        public async Task<Response<SubjectDto>> Handle(GetSubjectByIdQuery request, CancellationToken cancellationToken)
        {
            var subject = await _subjectService.GetByIdAsync(request.Id);
            if (subject == null)
                return _responseHandler.NotFound<SubjectDto>("Subject not found");

            var dto = _mapper.Map<SubjectDto>(subject);
            return _responseHandler.Success(dto);
        }
    }
}
