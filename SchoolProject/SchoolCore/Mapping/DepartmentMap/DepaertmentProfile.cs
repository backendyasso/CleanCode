using AutoMapper;
using SchoolCore.Features.Departments.Command.Models;
using SchoolCore.Features.Departments.Query.Result;
using SchoolData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Mapping.DepartmentMap
{
   public class DepaertmentProfile:Profile
    {
        public DepaertmentProfile()
        {
            
            CreateMap<AddDepartmentCommand, Department>()
                .ForMember(dest => dest.DID, opt => opt.Ignore()); 

            CreateMap<UpdateDepartmentCommand, Department>()
                .ForMember(dest => dest.Students, opt => opt.Ignore()) 
                .ForMember(dest => dest.DepartmentSubjects, opt => opt.Ignore());

           
            CreateMap<Department, DepartmentDto>(); 
        }
    }
}
