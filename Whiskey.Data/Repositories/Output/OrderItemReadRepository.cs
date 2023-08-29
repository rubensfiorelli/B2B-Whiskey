using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;
using Whiskey.Domain.Repository.Output;

namespace Whiskey.Data.Repositories.Output
{
    public sealed class OrderItemReadRepository : IOrderItemReadRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderItemReadRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<OrderItem>> GetAllOrderItemsAsync()
        {
            try
            {
                using var db = _db;
                var items = new List<OrderItem>();

                return await Task.Run(() => items);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
