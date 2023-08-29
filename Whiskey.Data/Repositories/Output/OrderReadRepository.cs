using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Data.Helpers;
using Whiskey.Domain.Entities;
using Whiskey.Domain.Repository.Output;

namespace Whiskey.Data.Repositories.Output
{
    public sealed class OrderReadRepository : IOrderReadRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderReadRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            using var db = _db;
            var orders = new List<Order>();

            return await Task.Run(() => orders);
        }

        public async Task<Order> GetOrderByCodeAsync(string codeOrder)
        {
            try
            {

                using var db = _db;
                return await Task.Run(() => OrderReadGetOrderNumberHelpers.GetOrderNumber(db, codeOrder));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Order> GetOrderById(Guid id)
        {
            IQueryable<Order> orders = _db.Orders
                .Include(o => o.CustomerId)
                .Where(se => se.Id.Equals(id))
                .AsNoTracking();


            return await orders.FirstOrDefaultAsync();
        }
    }
}
