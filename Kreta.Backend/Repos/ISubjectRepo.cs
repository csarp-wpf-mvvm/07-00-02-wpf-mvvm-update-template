using Kreta.Shared.Models.Entites;

namespace Kreta.Backend.Repos
{
    public interface ISubjectRepo : IRepositoryBase<Subject>
    {
        public IQueryable<Subject> SelectSubjectsWithSchoolClasses();
    }
}
