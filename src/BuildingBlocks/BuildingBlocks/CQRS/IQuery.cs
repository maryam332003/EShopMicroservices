using MediatR;
namespace BuildingBlocks.CQRS;
//this is a marker interface for queries that do not return a value,
//Query means that it is a request for data, and it does not change the state of the system
//what is the mean of unit in c#?
//Unit is a type that represents the absence of a value, it is similar to void in C#, but it can be used as a type parameter, and it can be used in generics, and it can be used in async methods, and it can be used in LINQ queries, and it can be used in functional programming, and it can be used in F# programming language, and it can be used in other programming languages that support generics, and it can be used in other programming languages that support functional programming, and it can be used in other programming languages that support LINQ queries, and it can be used in other programming languages that support async methods, and it can be used in other programming languages that support the concept of a unit type.
public interface IQuery : IQuery<Unit>
{

}
//this is a marker interface for queries that return a value
public interface IQuery<out TResponse> : IRequest<TResponse>
{

}
