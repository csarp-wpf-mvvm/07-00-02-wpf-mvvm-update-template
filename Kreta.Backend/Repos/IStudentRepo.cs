using Kreta.Shared.Models.Entites.SchoolCitizens;

namespace Kreta.Backend.Repos
{
    public interface IStudentRepo : IRepositoryBase<Student>
    {
        public IQueryable<Student> SelectAllIncluded();

        public IQueryable<Student> SelectStudentsByEducationId(Guid educationID);

        public IQueryable<Student> SelectStudentsWithoutEducationLevel();
    }
}
