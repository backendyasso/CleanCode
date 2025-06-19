using AutoMapper;
using MediatR;
using SchoolCore.Basics;
using SchoolCore.Features.Subjects.Command.Models;
using SchoolService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Subjects.Command.Handeler
{
    public class AddSubjectHandler : IRequestHandler<AddSubjectCommand, Response<string>>
    {
        private readonly IMapper _mapper;
        private readonly ISubjectService _service;
        private readonly ResponseHandler _responseHandler;

        public AddSubjectHandler(IMapper mapper, ISubjectService service, ResponseHandler responseHandler)
        {
            _mapper = mapper;
            _service = service;
            _responseHandler = responseHandler;
        }

        public async Task<Response<string>> Handle(AddSubjectCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<SchoolData.Entities.Subjects>(request);
            var result = await _service.AddAsync(entity);
            return _responseHandler.Success(result);
        }
    }
}
