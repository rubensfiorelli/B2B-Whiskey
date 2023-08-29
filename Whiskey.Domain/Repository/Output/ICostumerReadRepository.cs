using Whiskey.Domain.Entities;

namespace Whiskey.Domain.Repository.Output
{
    public interface ICostumerReadRepository
    {
        Task<List<Costumer>> GetAllOrdersAsync();
        Task<Costumer> GetIdAsync(Guid id);
        Task<List<Costumer>> GetLastNameAsync(string lastName);
    }
}
