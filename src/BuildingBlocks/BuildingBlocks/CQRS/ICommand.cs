using MediatR;
namespace BuildingBlocks.CQRS;
//this is a marker interface for commands that do not return a value
public interface ICommand : ICommand<Unit>
{
}
//this is a marker interface for commands that return a value
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
