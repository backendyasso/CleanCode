﻿using MediatR;
using SchoolCore.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Subjects.Command.Models
{
    public class DeleteSubjectCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public DeleteSubjectCommand(int id) => Id = id;
    }
}
