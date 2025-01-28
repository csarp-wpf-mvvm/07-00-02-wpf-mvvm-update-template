using Kreta.Shared.Models.Entites;

namespace Kreta.Backend.Repos
{
    public interface IEducationLevelRepo : IRepositoryBase<EducationLevel>
    {
        public IQueryable<EducationLevel> SelectAllIncluded();
    }
}
