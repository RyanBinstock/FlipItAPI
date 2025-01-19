namespace FlipIt.API.Interfaces
{
    public interface IAsyncRepository<T>
    {
        Task<T> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<T> UpdateAsync(T item, CancellationToken cancellationToken);
        Task<T> AddAsync(T item, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
