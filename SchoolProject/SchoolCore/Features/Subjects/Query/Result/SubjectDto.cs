using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Subjects.Query.Result
{
    public class SubjectDto
    {
        public int SubID { get; set; }
        public string SubjectName { get; set; }
        public DateTime Period { get; set; }
        public int DepartmentCount { get; set; }
    }
}
