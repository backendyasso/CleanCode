﻿using MediatR;
using SchoolCore.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Departments.Command.Models
{
    public class DeleteDepartmentCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }

        public DeleteDepartmentCommand(int id)
        {
            Id = id;
        }
    }

}
