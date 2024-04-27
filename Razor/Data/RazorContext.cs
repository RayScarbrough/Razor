using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor.Models;

namespace Razor.Data
{
    public class RazorContext : DbContext
    {
        public RazorContext (DbContextOptions<RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Razor.Models.Movie> Movie { get; set; } = default!;
    }
}
