using Whiskey.Domain.Entities;

namespace Whiskey.Domain.Repository.Output
{
    public interface IProductReadRepository
    {
        Task<List<Product>> GetByTitle(string title);
        Task<List<Product>> GetAllProductsAsync();
    }
}
