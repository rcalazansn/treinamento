using Microsoft.EntityFrameworkCore;
using RCN.Scafoold.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCN.Scafoold.Data
{
    public class ScafooldContext : DbContext
    {
        public ScafooldContext(DbContextOptions<ScafooldContext> options)
            : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
