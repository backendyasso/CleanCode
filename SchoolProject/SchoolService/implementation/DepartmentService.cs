using Microsoft.EntityFrameworkCore;
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
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepo _departmentRepo;

        public DepartmentService(IDepartmentRepo departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        public async Task<string> AddAsync(Department department)
        {
            
            var existingDepartment = await _departmentRepo.GetTableNoTracking()
                .Where(d => d.DName == department.DName)
                .FirstOrDefaultAsync();

            if (existingDepartment != null)
                return "Department already exists";

            await _departmentRepo.AddAsync(department);
            return "Department added successfully";
        }

        public async Task<List<Department>> GetAllAsync()
        {
            return await _departmentRepo.GetAllDepartmentsAsync();
        }

        public async Task<Department?> GetByIdAsync(int id)
        {
            var department = await _departmentRepo.GetTableNoTracking()
                .Include(d => d.Students)
                .FirstOrDefaultAsync(d => d.DID == id);

            return department;
        }

        public async Task UpdateAsync(Department department)
        {
            await _departmentRepo.UpdateAsync(department);
        }

        public async Task DeleteAsync(Department department)
        {
            await _departmentRepo.DeleteAsync(department);
        }
    }
}
