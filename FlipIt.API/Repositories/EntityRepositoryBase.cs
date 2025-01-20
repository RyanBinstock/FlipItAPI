using Microsoft.EntityFrameworkCore;
using FlipIt.API.EntityFramework;
using FlipIt.API.Interfaces;
using FlipIt.API.Models;
using FlipIt.API.Exceptions;

namespace FlipIt.API.Repositories
{
    public class EntityRepositoryBase<T> : IAsyncRepository<T>
        where T : EntityBase
    {
        protected readonly FlipItDbContext _context;

        public EntityRepositoryBase(FlipItDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T item, CancellationToken cancellationToken)
        {
            var dbEntry = await _context.Set<T>().AddAsync(item, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return dbEntry.Entity;
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _context.Set<T>().Where(x => x.Id == id).ExecuteDeleteAsync(cancellationToken);
        }

        public async Task<T> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            var item = await _context.Set<T>().Where(x => x.Id == id).FirstOrDefaultAsync(cancellationToken)
                ?? throw new EFMissingEntryException($"No entity with the id [{id}] was found in the database!");

            return item;
        }

        public async Task<T> UpdateAsync(T item, CancellationToken cancellationToken)
        {
            if (!await _context.Set<T>().AnyAsync(x => x.Id == item.Id, cancellationToken))
            {
                throw new EFMissingEntryException($"The given entity was not found in the database to update. Item Id: [{item.Id}]");
            }

            var dbEntry = _context.Set<T>().Update(item);
            await _context.SaveChangesAsync(cancellationToken);
            return dbEntry.Entity;
        }
    }
}
