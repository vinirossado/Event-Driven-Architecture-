using ECommerce.Domain.Models;
using ECommerce.Repository.Interfaces;

namespace ECommerce.Service.Command.Invoice
{
    public class DeleteInvoiceCommandHandler
    {
        private readonly IInvoiceRepository _customerRepository;
        public DeleteInvoiceCommandHandler(IInvoiceRepository customerRepository) => _customerRepository = customerRepository;

        public async Task<InvoiceModel> Handle(DeleteInvoiceCommand request, CancellationToken cancellationToken)
        {
            return await _customerRepository.DeleteAsync(request.Invoice);
        }
    }
}
