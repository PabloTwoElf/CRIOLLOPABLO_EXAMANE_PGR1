using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRIOLLOPABLO_EXAMANE_PGR1.Models;

namespace CRIOLLOPABLO_EXAMANE_PGR1.Data
{
    public class CRIOLLOPABLO_EXAMANE_PGR1Context : DbContext
    {
        public CRIOLLOPABLO_EXAMANE_PGR1Context (DbContextOptions<CRIOLLOPABLO_EXAMANE_PGR1Context> options)
            : base(options)
        {
        }

        public DbSet<CRIOLLOPABLO_EXAMANE_PGR1.Models.PCriollo> PCriollo { get; set; } = default!;
        public DbSet<CRIOLLOPABLO_EXAMANE_PGR1.Models.Celular> Celular { get; set; } = default!;
    }
}
