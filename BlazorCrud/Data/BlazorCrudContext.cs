using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Data
{
    public class BlazorCrudContext : DbContext
    {
        public BlazorCrudContext (DbContextOptions<BlazorCrudContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorCrud.Data.Transaction> Transaction { get; set; } = default!;
    }
}
