using Whiskey.Domain.Entities;

namespace Whiskey.Domain.Repository.Output
{
    public interface IOrderItemReadRepository
    {
        Task<List<OrderItem>> GetAllOrderItemsAsync();
    }
}
