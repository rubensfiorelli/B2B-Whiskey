using Whiskey.Application.Abstrations.Query.Interfaces;
using Whiskey.Application.Queries.QueryModel;
using Whiskey.Application.Queries.ResponseObjects;
using Whiskey.Domain.Repository.Output;

namespace Whiskey.Application.Queries
{
    public sealed class GetCategoryByIdQueryHandler : IQueryHandler<GetCategoryByIdQuery, CategoryResponse>
    {
        private ICategoryReadRepository _db;

        public GetCategoryByIdQueryHandler(ICategoryReadRepository db)
        {
            _db = db;
        }

        public async Task<CategoryResponse> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {

            var category = await _db.GetCategoryId(request.Id, cancellationToken);
            if (category is null)
                return null;

            var response = new CategoryResponse(category.Id, category.Title, category.Description);

            return response;

        }
    }
}
