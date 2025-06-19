using SchoolData.Entities;
using SchoolInfrastructure.InfrastructureBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolInfrastructure.Abstract
{
    public interface ISubjectRepo : IGenericRepositoryAsync<Subjects>
    {
        Task<List<Subjects>> GetAllSubjectsAsync();
        IQueryable<Subjects> GetTableNoTracking();
    }
}
