using Domain.Models;

namespace Service.Query
{
    public class FindInvoiceQuery: IRequest<Invoice>
    {
        public Guid InvoiceId { get; set; }
    }
}
