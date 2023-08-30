using Whiskey.Application.Abstrations.Query.Interfaces;
using Whiskey.Application.Queries.ResponseObjects;

namespace Whiskey.Application.Queries.QueryModel
{
    public sealed class GetCategoryByIdQuery : IQuery<CategoryResponse>
    {
        public Guid Id { get; }
    }
}
