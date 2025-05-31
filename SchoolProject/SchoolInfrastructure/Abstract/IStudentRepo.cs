using SchoolData.Entities;
using SchoolInfrastructure.InfrastructureBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfrastructure.Abstract
{
  public interface IStudentRepo:IGenericRepositoryAsync<Student>
    {
        public Task<List<Student>> GetAllStudentsAsync();
        IQueryable<Student> GetTableNoTracking();

       

    }
    
}
