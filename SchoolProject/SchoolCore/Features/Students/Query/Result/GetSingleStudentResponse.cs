using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Students.Query.Result
{
    public class GetSingleStudentResponse
    {
        //DTO

        public int StudID { get; set; }

        public string? Name { get; set; }

        public string ?Address { get; set; }

        public string? DepartmentName { get; set; }
    }
}
