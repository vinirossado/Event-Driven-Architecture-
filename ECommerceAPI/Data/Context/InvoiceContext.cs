using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.Context
{
    public partial class InvoiceDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public InvoiceDbContext(IConfiguration configuration, DbContextOptions<InvoiceDbContext> options) : base(options)
        {
            _configuration = configuration;
        }
        public virtual DbSet<Invoice> Invoice { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>().ToTable("Invoice");

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }

}

