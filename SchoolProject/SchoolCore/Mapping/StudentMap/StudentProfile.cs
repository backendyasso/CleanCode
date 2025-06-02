using AutoMapper;

using SchoolCore.Features.Students.Query.Models;
using SchoolCore.Features.Students.Query.Result;
using SchoolData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Mapping.StudentMap
{
   public partial class StudentProfile:Profile
    {

        public StudentProfile()
        {
            GetStudentListMapping();
            GetStudentByIDMapping();
            AddStudentCommandMapping();
        }
        
    }
}
