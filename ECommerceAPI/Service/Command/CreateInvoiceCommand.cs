using Domain.Models;
using MediatR;

namespace Service.Command
{
    public class CreateInvoiceCommand : IRequest<Invoice>
    {
        public Invoice Invoice { get; set; }
    }
}
