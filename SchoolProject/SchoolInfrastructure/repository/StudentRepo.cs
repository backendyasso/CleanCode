using Microsoft.EntityFrameworkCore;
using SchoolData.Entities;
using SchoolInfrastructure.Abstract;
using SchoolInfrastructure.Data;
using SchoolInfrastructure.InfrastructureBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfrastructure.repository
{
 public  class StudentRepo: GenericRepositoryAsync<Student> ,IStudentRepo
    {
        private readonly DbSet<Student> Student;

        public  StudentRepo(ApplicationDBContext DB):base(DB)
        {
            Student = DB.Set<Student>();
        }
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return  await Student.Include(d=>d.Department).ToListAsync();
        }

        public IQueryable<Student> GetTableNoTracking()
        {
            return  Student.AsNoTracking();
        }
    }
}
