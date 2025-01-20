using FlipIt.API.EntityFramework;
using FlipIt.API.Models;

namespace FlipIt.API.Repositories
{
    public class PartsRepository : EntityRepositoryBase<Part>
    {
        private readonly FlipItDbContext _context;

        public PartsRepository(FlipItDbContext context) : base(context) 
        {
            _context = context;
        }
    }
}
