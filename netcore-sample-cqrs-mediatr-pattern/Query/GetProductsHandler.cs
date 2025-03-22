using MediatR;
using Microsoft.EntityFrameworkCore;
using netcore_sample_cqrs_mediatr_pattern.DBContext;
using netcore_sample_cqrs_mediatr_pattern.Model;

namespace netcore_sample_cqrs_mediatr_pattern.Query
{
    public record GetProductsQuery() : IRequest<List<Product>>;

    public class GetProductsHandler : IRequestHandler<GetProductsQuery, List<Product>>
    {
        private readonly ProductDbContext _context;
        public GetProductsHandler(ProductDbContext context) => _context = context;

        public async Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync();
        }
    }
}
