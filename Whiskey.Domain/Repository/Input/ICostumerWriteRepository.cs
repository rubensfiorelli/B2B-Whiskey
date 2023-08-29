using Whiskey.Domain.Entities;

namespace Whiskey.Domain.Repository.Input
{
    public interface ICostumerWriteRepository : IUnitOfWork
    {
        Task AddAsync(Costumer costumer);
    }
}
