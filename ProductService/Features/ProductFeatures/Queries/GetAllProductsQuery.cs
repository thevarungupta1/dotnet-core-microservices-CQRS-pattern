using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ProductService.Models;
using ProductService.Context;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace ProductService.Features.ProductFeatures.Queries
{
    public class GetAllProductsQuery:IRequest<IEnumerable<Product>>
    {
        public class GetAllProductsQueryHandler: IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
        {
            private readonly IApplicationContext _context;

            public GetAllProductsQueryHandler(IApplicationContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery command, CancellationToken cancellationToken)
            {
                var productList =  await _context.Products.ToListAsync();
                if (productList == null)
                    return null;
                return productList.AsReadOnly();
            }
        }
    }
}
