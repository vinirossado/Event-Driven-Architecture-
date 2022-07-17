using Domain.Models;

namespace Service.Command
{
    public class DeleteInvoiceCommand
    {
        public Invoice Invoice { get; set; }
    }
}
