using MediatR;
namespace BuildingBlocks.CQRS;
//describe ICommandHandler implementation in C# 12.0
//ICommandHandler is an interface that defines a handler for a command in the CQRS pattern. It inherits from IRequestHandler<TCommand, TResponse> from MediatR library, which means it can handle requests of type TCommand and return responses of type TResponse.
//The interface has two generic type parameters: TCommand, which must implement ICommand<TResponse>, and TResponse, which must be a non-nullable type. This allows for strong typing and ensures that the command handler can only handle commands that return a specific response type.
//MediatR
//│
//├── IRequest<TResponse>
//│
//└── IRequestHandler<TRequest, TResponse>
//          ↑
//          │
//      our abstraction
//          │
//    ┌─────┴─────┐
//    │           │
// ICommand ICommandHandler

//this is a marker interface for command handlers that do not return a value
internal interface ICommandHandler<in TCommand>
    : ICommandHandler<TCommand, Unit>
    where TCommand : ICommand<Unit>
{
}

internal interface ICommandHandler<in TCommand,TResponse>
    :IRequestHandler<TCommand,TResponse>
    where TCommand : ICommand<TResponse>
    where TResponse : notnull
{
}