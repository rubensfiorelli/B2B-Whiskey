using Whiskey.Application.Abstrations.Command;
using Whiskey.Application.Abstrations.Handler.Interfaces;
using Whiskey.Domain.Entities;
using Whiskey.Domain.Repository.Input;
using Whiskey.Domain.Results;

namespace Whiskey.Application.Abstrations.Handler
{

    public sealed class CreateCategoryCommandHandler : IHandler<CreateCategoryCommand>
    {
        private readonly ICategoryWriteRepository _db;

        public CreateCategoryCommandHandler(ICategoryWriteRepository db)
        {
            _db = db;
        }

        public async Task<Result> Handle(CreateCategoryCommand command)
        {
            var category = new Category(command.Title, command.Description);

            await _db.AddAsync(category);
            await _db.Commit();

            return new Result(201, $"Category, successfully created!", category.Id);
        }
    }
}
