using ECommerce.Domain.Models;
using ECommerce.Repository.Interfaces;

namespace ECommerce.Service.Command.Invoice
{
    public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, InvoiceModel>
    {
        private readonly IInvoiceRepository _invoiceRepository;
        public CreateInvoiceCommandHandler(IInvoiceRepository customerRepository) => _invoiceRepository = customerRepository;

        public async Task<InvoiceModel> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
            return await _invoiceRepository.AddAsync(request.Invoice);
        }
    }
}
