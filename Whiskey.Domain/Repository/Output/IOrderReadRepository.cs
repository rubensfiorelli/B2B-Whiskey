using Whiskey.Domain.Entities;

namespace Whiskey.Domain.Repository.Output
{
    public interface IOrderReadRepository
    {
        Task<Order> GetOrderByCodeAsync(string codeOrder);
        Task<List<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderById(Guid id);

    }
}
