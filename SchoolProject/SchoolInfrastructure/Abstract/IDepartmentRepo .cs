using SchoolData.Entities;
using SchoolInfrastructure.InfrastructureBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfrastructure.Abstract
{
    public interface IDepartmentRepo : IGenericRepositoryAsync<Department>
    {
        Task<List<Department>> GetAllDepartmentsAsync();
        IQueryable<Department> GetTableNoTracking();
    }
}
