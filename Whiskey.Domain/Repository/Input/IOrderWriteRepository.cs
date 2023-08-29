using Whiskey.Domain.Entities;

namespace Whiskey.Domain.Repository.Input
{
    public interface IOrderWriteRepository : IUnitOfWork
    {
        Task AddAsync(Order order);
    }
}
