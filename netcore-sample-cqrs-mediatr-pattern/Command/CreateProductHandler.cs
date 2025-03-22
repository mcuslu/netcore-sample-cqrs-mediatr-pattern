using MediatR;
using netcore_sample_cqrs_mediatr_pattern.DBContext;
using netcore_sample_cqrs_mediatr_pattern.Model;

namespace netcore_sample_cqrs_mediatr_pattern.Command
{
    public record CreateProductCommand(string Name, decimal? Price, string? StockCode) : IRequest<int>;

    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly ProductDbContext _context;
        public CreateProductHandler(ProductDbContext context) => _context = context;

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                StockCode = request.StockCode,
                CreateDate = DateTime.UtcNow
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }
    }

}
