using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tricount.Entities.Concrete;

namespace Tricount.DAL.Contexts
{
    public class SqlDbContext : IdentityDbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }

        public SqlDbContext()
        {
            
        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Tricount1;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
