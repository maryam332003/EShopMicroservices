using MediatR;

namespace Catalog.API.Products.CreateProduct;
//request and result records for the CreateProductHandler
public record CreateProductCommand(string Name, string Description, decimal Price, List<string> Category, string ImageFile)
    :IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);
internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public CreateProductCommandHandler()
    {
    }
    public async Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
       throw new NotImplementedException();
    }
}