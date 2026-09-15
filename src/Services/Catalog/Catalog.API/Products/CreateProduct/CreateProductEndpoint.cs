namespace Catalog.API.Products.CreateProduct;
public record CreateProductRequest(string Name, string Description, decimal Price, List<string> Category, string ImageFile);
public record CreateProductResponse(Guid Id);
public class CreateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        //this endpoint is responsible for creating a new product, it will receive a CreateProductRequest and return a CreateProductResponse
        app.MapPost("/products", async (CreateProductRequest request, ISender sender) =>
        {
            //map the request to the command using Mapster
            var command = request.Adapt<CreateProductCommand>();
            //send the command to the handler using MediatR mean that the command will be handled by the appropriate handler
            var result = await sender.Send(command);
            var response = result.Adapt<CreateProductResponse>();
            return Results.Created($"/products/{response.Id}", response);

        }).WithName("CreateProduct")
        .Produces<CreateProductResponse>()
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Create Product")
        .WithDescription("Create Product");
    }
}