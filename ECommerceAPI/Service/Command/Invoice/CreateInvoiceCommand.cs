using ECommerce.Domain.Models;

namespace ECommerce.Service.Command.Invoice
{
    public class CreateInvoiceCommand : IRequest<InvoiceModel>
    {
        public InvoiceModel Invoice { get; set; }
    }
}
