namespace Catalog.API.Products.CreateProduct;
//request and result records for the CreateProductHandler
public record CreateProductCommand(string Name, string Description, decimal Price, List<string> Category, string ImageFile)
    :ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);
internal class CreateProductCommandHandler 
    : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //create product entity from command data
        var product = new Product
        {
            Name = command.Name,
            Description = command.Description,
            Price = command.Price,
            Category = command.Category,
            ImageFile = command.ImageFile
        };
        //save product entity to database
        //return CreateProductResult result
        return Task.FromResult(new CreateProductResult(Guid.NewGuid()));
    }
}