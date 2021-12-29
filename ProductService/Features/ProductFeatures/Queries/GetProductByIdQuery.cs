using MediatR;
using ProductService.Context;
using ProductService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductService.Features.ProductFeatures.Queries
{
    public class GetProductByIdQuery:IRequest<Product>
    {
        public int Id { get; set; }
        public class GetProductByIdQueryHandler: IRequestHandler<GetProductByIdQuery, Product>
        {
            private readonly IApplicationContext _context;
            public GetProductByIdQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<Product> Handle(GetProductByIdQuery command, CancellationToken cancellationToken)
            {
                var product = _context.Products.Where(a => a.Id == command.Id).FirstOrDefault();
                if (product == null)
                    return null;
                return product;
            }
        }
    }
}
