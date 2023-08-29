using MediatR;

namespace Whiskey.Application.Abstrations.Query.Interfaces
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }
}
