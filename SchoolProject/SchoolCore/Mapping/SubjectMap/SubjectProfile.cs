using AutoMapper;
using SchoolCore.Features.Subjects.Command.Models;
using SchoolCore.Features.Subjects.Query.Result;
using SchoolData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Mapping.SubjectMap
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<AddSubjectCommand, Subjects>().ForMember(dest => dest.SubID, opt => opt.Ignore());
            CreateMap<UpdateSubjectCommand, Subjects>();
            CreateMap<Subjects, SubjectDto>()
                .ForMember(dest => dest.DepartmentCount, opt => opt.MapFrom(src => src.DepartmetsSubjects.Count));
        }
    }
}
