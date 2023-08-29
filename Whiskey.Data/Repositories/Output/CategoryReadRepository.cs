using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;
using Whiskey.Domain.Repository.Output;

namespace Whiskey.Data.Repositories.Output
{
    public sealed class CategoryReadRepository : ICategoryReadRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryReadRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task<List<Category>> GetAllOrdersAsync()
        {

            try
            {

                IQueryable<Category> categories = _db.Categories
                    .Take(20)
                    .AsNoTracking();

                return await categories.ToListAsync();


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Category> GetCategoryId(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                using var db = _db;

                return await Task.Run(() => CategoryIdHelpers.CategoryById(db, id));


            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
