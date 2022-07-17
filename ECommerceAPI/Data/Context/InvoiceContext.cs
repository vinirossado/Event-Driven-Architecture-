using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public partial class InvoiceDbContext : DbContext
    {
        public InvoiceDbContext()
        {
        }
        public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public virtual DbSet<Invoice> Invoice { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>().ToTable("Invoice");

            OnModelCreating(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }

}

