using Kreta.Shared.Models.Entites;

namespace Kreta.Backend.Repos
{
    public interface ISchoolClassRepo : IRepositoryBase<SchoolClass>
    {
        public IQueryable<SchoolClass> SelectAllIncluded();
        public IQueryable<SchoolClass> GetSchoolClassBy(Guid typeOfEducationID);
        public IQueryable<SchoolClass> SelectWithoutTypeOfEducation();
        public IQueryable<SchoolClass> SelectSchoolClassesWithSubjects();
    }
}
