using ECommerce.Domain.Models;

namespace ECommerce.Service.Query.Invoice
{
    public class FindInvoiceQuery : IRequest<InvoiceModel>
    {
        public Guid InvoiceId { get; set; }
    }
}
