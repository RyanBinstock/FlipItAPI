using FlipIt.API.EntityFramework;
using FlipIt.API.Models;

namespace FlipIt.API.Repositories
{
    public class VendorsRepository : EntityRepositoryBase<Vendor>
    {
        private readonly FlipItDbContext _context; 

        public VendorsRepository(FlipItDbContext context) : base(context) 
        {
            _context = context;
        }
    }
}
