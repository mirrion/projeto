using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAsp.Models
{
    public class ProjetoAspContext : DbContext
    {
        public ProjetoAspContext (DbContextOptions<ProjetoAspContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoAsp.Models.Department> Department { get; set; }
    }
}
