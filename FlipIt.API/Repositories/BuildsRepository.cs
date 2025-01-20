using FlipIt.API.EntityFramework;
using FlipIt.API.Models;

namespace FlipIt.API.Repositories
{
    public class BuildsRepository : EntityRepositoryBase<Build>
    {
        private readonly FlipItDbContext _context;

        public BuildsRepository(FlipItDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
