using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;
using Whiskey.Domain.Repository.Input;

namespace Whiskey.Data.Repositories.Input
{
    public sealed class CostumerWriteRepository : ICostumerWriteRepository
    {
        private ApplicationDbContext _db;

        public CostumerWriteRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Costumer costumer)
        {
            try
            {
                var result = await _db.Costumers.FirstOrDefaultAsync(c => c.Id.Equals(costumer.Id));

                if (result is null)
                    costumer.CreateAt = DateTime.Now;

                _db.Costumers.Add(costumer);

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
