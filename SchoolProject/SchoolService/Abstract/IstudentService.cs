using SchoolData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolService.Abstract
{
   public interface IstudentService
    {
        public Task<List<Student>> GetAllStudentsAsync();
        public  Task<Student> GetStudentByIdAsync(int id);

        public Task<string> AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(Student student);

    } 
}
