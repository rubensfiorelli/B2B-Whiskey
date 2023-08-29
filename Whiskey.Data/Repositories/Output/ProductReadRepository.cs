using Microsoft.EntityFrameworkCore;
using Whiskey.Data.DatabaseContext;
using Whiskey.Domain.Entities;
using Whiskey.Domain.Repository.Output;

namespace Whiskey.Data.Repositories.Output
{
    public sealed class ProductReadRepository : IProductReadRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductReadRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            using var db = _db;
            var products = new List<Product>();

            return await Task.Run(() => products);
        }

        public async Task<List<Product>> GetByTitle(string title)
        {
            IQueryable<Product> products = (IQueryable<Product>)_db.Products
               .Select(ln => ln.Title.Normalize())
               .AsNoTracking();


            return await products.ToListAsync();
        }
    }
}
