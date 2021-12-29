using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductService.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChangesAsync();
    }
}
