using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;
using Whiskey.Domain.Repository.Input;

namespace Whiskey.Data.Repositories.Input
{
    public sealed class OrderWriteRepository : IOrderWriteRepository
    {

        private readonly ApplicationDbContext _db;

        public OrderWriteRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task AddAsync(Order order)
        {
            try
            {
                var result = await _db.Orders.FirstOrDefaultAsync(c => c.Id.Equals(order.Id));

                if (result is null)
                    order.CreateAt = DateTime.Now;

                _db.Orders.Add(order);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Commit()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}
