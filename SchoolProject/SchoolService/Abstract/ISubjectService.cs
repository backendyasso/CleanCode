using SchoolData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolService.Abstract
{
    public interface ISubjectService
    {
        Task<string> AddAsync(Subjects subject);
        Task UpdateAsync(Subjects subject);
        Task DeleteAsync(Subjects subject);
        Task<Subjects?> GetByIdAsync(int id);
        Task<List<Subjects>> GetAllAsync();
    }
}
