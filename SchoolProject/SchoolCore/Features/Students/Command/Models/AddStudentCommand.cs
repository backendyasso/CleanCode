﻿using MediatR;
using SchoolCore.Basics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Students.Command.Models
{    
 public class AddStudentCommand: IRequest<Response<string>>
    {
    
        public string Name { get; set; }
        
        public string Address { get; set; }

        public string? Phone { get; set; }

        public int DepartmentId { get; set; }
    }
}
