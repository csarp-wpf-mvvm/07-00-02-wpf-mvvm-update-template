using Kreta.Shared.Models.Entites.SwitchTable;

namespace Kreta.Backend.Repos.SwitchTables
{
    public interface ISchoolClassStudentsRepo : IRepositoryBase<SchoolClassStudents>
    {
        public IQueryable<SchoolClassStudents> SelectAllIncluded();
    }
}
