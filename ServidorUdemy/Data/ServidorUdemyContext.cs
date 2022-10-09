using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServidorUdemy.Models;

namespace ServidorUdemy.Data
{
    public class ServidorUdemyContext : DbContext
    {
        public ServidorUdemyContext (DbContextOptions<ServidorUdemyContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord { get; set; } = default!;
    }
}
