using Kreta.Shared.Models.Entites.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class ParentRepo<TDbContext> : RepositoryBase<TDbContext, Parent>, IParentRepo
        where TDbContext : DbContext
    {
        public ParentRepo(TDbContext? dbContext) : base(dbContext)
        {

        }
    }
}
