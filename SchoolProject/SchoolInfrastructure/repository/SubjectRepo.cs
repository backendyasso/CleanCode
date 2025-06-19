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
    public class SubjectRepo : GenericRepositoryAsync<Subjects>, ISubjectRepo
    {
        private readonly DbSet<Subjects> _subjects;

        public SubjectRepo(ApplicationDBContext db) : base(db)
        {
            _subjects = db.Set<Subjects>();
        }

        public async Task<List<Subjects>> GetAllSubjectsAsync()
        {
            return await _subjects.ToListAsync();
        }

        public IQueryable<Subjects> GetTableNoTracking()
        {
            return _subjects.AsNoTracking();
        }
    }
}
