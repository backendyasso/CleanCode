using SchoolData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolService.Abstract
{
    public interface IDepartmentService
    {
        Task<string> AddAsync(Department department);
        Task UpdateAsync(Department department);
        Task DeleteAsync(Department department);
        Task<Department?> GetByIdAsync(int id);
        Task<List<Department>> GetAllAsync();
    }
}
