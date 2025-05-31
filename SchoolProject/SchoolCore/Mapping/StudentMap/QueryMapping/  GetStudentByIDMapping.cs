using AutoMapper;
using SchoolCore.Features.Students.Query.Result;
using SchoolData.Entities;

namespace SchoolCore.Mapping.StudentMap
{
    public partial class StudentProfile
    {
        public void GetStudentByIDMapping()
        {
            CreateMap<Student, GetSingleStudentResponse>()  
                .ForMember(d => d.DepartmentName,
                           s => s.MapFrom(src => src.Department.DName));
        }
    }
}