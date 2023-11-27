using InsertionSortAlgorthem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlgorthem.DataAccess.Data
{
    public class SortAlgoDbContext : DbContext
    {
        public SortAlgoDbContext(DbContextOptions<SortAlgoDbContext> options)
            : base(options)
        {
        }

        // public DbSet<TbProduct> TbProducts { get; set; }
        public DbSet<TbEmbloyee> TbEmbloyees { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}

