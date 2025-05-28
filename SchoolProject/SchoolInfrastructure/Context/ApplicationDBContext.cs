using Microsoft.EntityFrameworkCore;
using SchoolData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfrastructure.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subjects> Subjects { get; set; }


        public DbSet<StudentSubject> StudentSubjects { get; set; }

        public DbSet<DepartmetSubject> DepartmetSubjects { get; set; }


    }
}
