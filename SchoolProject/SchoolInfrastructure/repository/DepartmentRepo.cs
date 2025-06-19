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
    public class DepartmentRepo : GenericRepositoryAsync<Department>, IDepartmentRepo
    {
        private readonly DbSet<Department> _department;

        public DepartmentRepo(ApplicationDBContext db) : base(db)
        {
            _department = db.Set<Department>();
        }

        public async Task<List<Department>> GetAllDepartmentsAsync()
        {
            return await _department.Include(d => d.Students).ToListAsync();
        }

        public IQueryable<Department> GetTableNoTracking()
        {
            return _department.AsNoTracking();
        }
    }
}
