using Whiskey.Application.Abstrations.Command.Interfaces;
using Whiskey.Domain.Results;

namespace Whiskey.Application.Abstrations.Handler.Interfaces
{
    public interface IHandler<in TCommand> where TCommand : ICommand
    {
        Task<Result> Handle(TCommand command);
    }
}
