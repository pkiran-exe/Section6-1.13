using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProject3.Models;

namespace PracticeProject3.Data
{
    public class PP3DbContext : DbContext
    {
        public PP3DbContext (DbContextOptions<PP3DbContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeProject3.Models.Subject> Subject { get; set; } = default!;
    }
}
