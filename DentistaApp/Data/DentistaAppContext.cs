using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DentistaApp.Models;

namespace DentistaApp.Models
{
    public class DentistaAppContext : DbContext
    {
        public DentistaAppContext (DbContextOptions<DentistaAppContext> options)
            : base(options)
        {
        }

        public DbSet<DentistaApp.Models.Fornecedor> Fornecedor { get; set; }

        public DbSet<DentistaApp.Models.Produto> Produto { get; set; }
    }
}
