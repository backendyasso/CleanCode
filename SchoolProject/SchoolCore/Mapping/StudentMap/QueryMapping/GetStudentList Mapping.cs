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
        public void GetStudentListMapping() { 
        CreateMap<Student, GetStudentListResponse>().ForMember
               (d=>d.DepartmentName, s=>s.MapFrom(s=>s.Department.DName));
    }
}
}
         