using MediatR;
using SchoolCore.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Students.Command.Models
{
    public class DeleteStudentCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }

        public DeleteStudentCommand(int id)
        {
            Id = id;
        }
    }
}
