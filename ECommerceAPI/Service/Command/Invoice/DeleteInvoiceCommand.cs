using ECommerce.Domain.Models;

namespace ECommerce.Service.Command.Invoice
{
    public class DeleteInvoiceCommand
    {
        public InvoiceModel Invoice { get; set; }
    }
}
