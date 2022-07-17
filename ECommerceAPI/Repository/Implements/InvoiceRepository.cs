using Data.Context;
using Domain.Models;
using Repository.Base;
using Repository.Interface;

namespace Repository.Implements
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(InvoiceDbContext invoiceDbContext) : base(invoiceDbContext)
        {
        }
    
    }
}
