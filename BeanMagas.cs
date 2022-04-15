using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace homework_theme_18
{
    public partial class BeanMagas : DbContext
    {
        public BeanMagas()
            : base("name=BeanMagas")
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>()
                .Property(e => e.ClientEmail)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsFixedLength();
        }
    }
}
