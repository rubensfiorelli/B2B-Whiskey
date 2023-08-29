using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;
using Whiskey.Domain.Repository.Input;

namespace Whiskey.Data.Repositories.Input
{
    public sealed class CategoryWriteRepository : ICategoryWriteRepository
    {
        private ApplicationDbContext _db;

        public CategoryWriteRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Category category)
        {
            try
            {
                var result = await _db.Categories.FirstOrDefaultAsync(c => c.Id.Equals(category.Id));

                if (result is null)
                    category.CreateAt = DateTime.Now;

                _db.Categories.Add(category);

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
