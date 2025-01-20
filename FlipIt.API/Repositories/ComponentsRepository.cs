using FlipIt.API.EntityFramework;
using FlipIt.API.Models;

namespace FlipIt.API.Repositories
{
    public class ComponentsRepository : EntityRepositoryBase<Component>
    {
        private readonly FlipItDbContext _context; 

        public ComponentsRepository(FlipItDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
