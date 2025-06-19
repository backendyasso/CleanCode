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
    public class DeleteSubjectHandler : IRequestHandler<DeleteSubjectCommand, Response<string>>
    {
        private readonly ISubjectService _service;
        private readonly ResponseHandler _responseHandler;

        public DeleteSubjectHandler(ISubjectService service, ResponseHandler responseHandler)
        {
            _service = service;
            _responseHandler = responseHandler;
        }

        public async Task<Response<string>> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
        {
            var entity = await _service.GetByIdAsync(request.Id);
            if (entity == null) return _responseHandler.NotFound<string>("Subject not found");
            await _service.DeleteAsync(entity);
            return _responseHandler.Deleted<string>();
        }
    }
}
