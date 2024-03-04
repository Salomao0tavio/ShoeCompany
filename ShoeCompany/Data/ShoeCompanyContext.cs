using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShoeCompany.Models;

namespace ShoeCompany.Data
{
    public class ShoeCompanyContext : DbContext
    {
        public ShoeCompanyContext (DbContextOptions<ShoeCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<ShoeCompany.Models.Product> Product { get; set; } = default!;
    }
}
