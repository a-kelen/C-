using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ef5
{
    class Db:DbContext
    {
        public Db()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-V3TJMDN5\SQLEXPRESS;Database=BillsPaymentSystem;Trusted_Connection=True;");
        }
        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property("Email").IsUnicode(false);
            modelBuilder.Entity<User>().Property("Password").IsUnicode(false);
        }

    }
}
