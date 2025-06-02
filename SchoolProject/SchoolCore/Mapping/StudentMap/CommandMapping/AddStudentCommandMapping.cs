using SchoolCore.Features.Students.Command.Models;
using SchoolCore.Features.Students.Query.Result;
using SchoolData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Mapping.StudentMap
{
    public partial class StudentProfile
    {
        public void AddStudentCommandMapping()
        {
            CreateMap<AddStudentCommand, Student>()
                .ForMember(d => d.DID,
                           s => s.MapFrom(src => src.DepartmentId));
        }
    }
}
