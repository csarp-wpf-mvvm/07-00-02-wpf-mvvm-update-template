using Kreta.Shared.Models.Entites;

namespace Kreta.Backend.Repos
{
    public interface ITypeOfEducationRepo : IRepositoryBase<TypeOfEducation>
    {
        public IQueryable<TypeOfEducation> SelectAllIncluded();
    }
}
