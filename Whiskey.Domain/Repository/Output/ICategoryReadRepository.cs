using Whiskey.Domain.Entities;

namespace Whiskey.Domain.Repository.Output
{
    public interface ICategoryReadRepository
    {
        Task<List<Category>> GetAllOrdersAsync();
        Task<Category> GetCategoryId(Guid id, CancellationToken cancellationToken);
    }
}
