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
    public class GetSubjectListHandler : IRequestHandler<GetSubjectListQuery, Response<List<SubjectDto>>>
    {
        private readonly ISubjectService _service;
        private readonly IMapper _mapper;
        private readonly ResponseHandler _responseHandler;

        public GetSubjectListHandler(ISubjectService service, IMapper mapper, ResponseHandler responseHandler)
        {
            _service = service;
            _mapper = mapper;
            _responseHandler = responseHandler;
        }

        public async Task<Response<List<SubjectDto>>> Handle(GetSubjectListQuery request, CancellationToken cancellationToken)
        {
            var subjects = await _service.GetAllAsync();
            var result = _mapper.Map<List<SubjectDto>>(subjects);
            return _responseHandler.Success(result);
        }
    }
}
