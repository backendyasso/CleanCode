//using Microsoft.EntityFrameworkCore;
//using SchoolData.Entities;
//using SchoolInfrastructure.Abstract;
//using SchoolService.Abstract;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SchoolService.implementation
//{
//    public class StudentService : IstudentService
//    {
//        private readonly IStudentRepo studentRepo;

//        public StudentService(IStudentRepo studentRepo)
//        {
//            this.studentRepo = studentRepo;
//        }
//        public async Task<List<Student>> GetAllStudentsAsync()
//        {
//            return await studentRepo.GetAllStudentsAsync();
//        }

//        //public async Task<Student> GetStudentByIdAync(int id)
//        //{

//        //    // first l go to get the list of students then fitlter by id,IQueryable filter at database
//        //    //var Student = await studentRepo.GetByIdAsync(id);

//        //    var Student = await studentRepo.GetTableNoTracking().Include(d => d.Department)
//        //         .Where(s => s.StudID == id).FirstOrDefault();
//        //    return (Student);

//        //}


//        public async Task<Student?> GetStudentByIdAsync(int id)
//        {

//            return await _studentRepo.GetTableNoTracking()
//                .Include(d => d.Department)
//                .FirstOrDefaultAsync(s => s.StudID == id);
//        }
//    }
//}
using Microsoft.EntityFrameworkCore;
using SchoolData.Entities;
using SchoolInfrastructure.Abstract;
using SchoolService.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolService.implementation
{
    public class StudentService : IstudentService
    {
        private readonly IStudentRepo _studentRepo;

        public StudentService(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public async Task<string> AddAsync(Student student)
        {
            // Check if the student already exists
            var existingStudent = await _studentRepo.GetTableNoTracking()
                .Where(s => s.Name == student.Name)
                .FirstOrDefaultAsync();

            if (existingStudent != null)
                return "Already exist";

            // Add the student
            await _studentRepo.AddAsync(student);
            return "Student added successfully";
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _studentRepo.GetAllStudentsAsync();
        }

        public async Task<Student?> GetStudentByIdAsync(int id) 
        {
            var student = _studentRepo.GetTableNoTracking().Include
                (d => d.Department).Where(s => s.StudID == id).FirstOrDefault();
            return student;
        }
    }
}