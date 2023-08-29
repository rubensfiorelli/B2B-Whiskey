using Whiskey.Domain.Entities;

namespace Whiskey.Domain.Repository.Input
{
    public interface ICategoryWriteRepository : IUnitOfWork
    {
        Task AddAsync(Category category);

    }
}
