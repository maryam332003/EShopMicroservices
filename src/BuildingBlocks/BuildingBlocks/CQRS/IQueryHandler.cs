using MediatR;

namespace BuildingBlocks.CQRS;

internal interface IQueryHandler<in TQuery> : IRequestHandler<TQuery,Unit>
    where TQuery : IQuery<Unit>
{
}
internal interface IQueryHandler<in TQuery,TResponse>:IRequestHandler<TQuery,TResponse>
    where TQuery:IQuery<TResponse>
{
}
