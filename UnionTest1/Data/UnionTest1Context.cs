using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnionTest1;

namespace UnionTest1.Data
{
    public class UnionTest1Context : DbContext
    {
        public UnionTest1Context (DbContextOptions<UnionTest1Context> options)
            : base(options)
        {
        }

        public DbSet<UnionTest1.Product> Product { get; set; } = default!;
    }
}
