using Microsoft.EntityFrameworkCore;
using SchoolData.Entities;
using SchoolInfrastructure.Abstract;
using SchoolService.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolService.implementation
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepo _subjectRepo;

        public SubjectService(ISubjectRepo subjectRepo)
        {
            _subjectRepo = subjectRepo;
        }

        public async Task<string> AddAsync(Subjects subject)
        {
            // Check if the subject already exists by name
            var existing = await _subjectRepo.GetTableNoTracking()
                .Where(s => s.SubjectName == subject.SubjectName)
                .FirstOrDefaultAsync();

            if (existing != null)
                return "Subject already exists";

            await _subjectRepo.AddAsync(subject);
            return "Subject added successfully";
        }

        public async Task<List<Subjects>> GetAllAsync()
        {
            return await _subjectRepo.GetAllSubjectsAsync();
        }

        public async Task<Subjects?> GetByIdAsync(int id)
        {
            return await _subjectRepo.GetTableNoTracking()
    .Include(s => s.DepartmetsSubjects)
        .ThenInclude(ds => ds.Department)
    .FirstOrDefaultAsync(s => s.SubID == id);

        }

        public async Task UpdateAsync(Subjects subject)
        {
            await _subjectRepo.UpdateAsync(subject);
        }

        public async Task DeleteAsync(Subjects subject)
        {
            await _subjectRepo.DeleteAsync(subject);
        }
    }
}
