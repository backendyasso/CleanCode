using AutoMapper;
using SchoolCore.Features.Students.Query.Result;
using SchoolData.Entities;

namespace SchoolCore.Mapping.StudentMap
{
    public partial class StudentProfile
    {
        public void GetStudentListMapping()
        {
            CreateMap<Student, GetStudentListResponse>()  
                .ForMember(d => d.DepartmentName,
                           s => s.MapFrom(src => src.Department.DName));
        }
    }
}