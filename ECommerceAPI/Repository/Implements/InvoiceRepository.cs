using ECommerce.Data.Context;
using ECommerce.Domain.Models;
using ECommerce.Repository.Base;
using ECommerce.Repository.Interfaces;

namespace ECommerce.Repository.Implements
{
    public class InvoiceRepository : GenericRepository<InvoiceModel>, IInvoiceRepository
    {
        public InvoiceRepository(InvoiceDbContext invoiceDbContext) : base(invoiceDbContext)
        {
        }
    
    }
}
