using SchoolData.Entities;
using SchoolInfrastructure.Abstract;
using SchoolService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolService.implementation
{
    public class StudentService : IstudentService
    {
        private readonly IStudentRepo studentRepo;

        public StudentService(IStudentRepo studentRepo)
        {
            this.studentRepo = studentRepo;
        }
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await studentRepo.GetAllStudentsAsync();
        }

        public async Task<Student> GetStudentByIdAync(int id)
        { 


            var Student = await studentRepo.GetByIdAsync(id);
            return (Student);
               
        }
    }
}
