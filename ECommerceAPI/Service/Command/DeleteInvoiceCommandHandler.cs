using Domain.Models;
using Repository.Interface;

namespace Service.Command
{
    public class DeleteInvoiceCommandHandler
    {
        private readonly IInvoiceRepository _customerRepository;
        public DeleteInvoiceCommandHandler(IInvoiceRepository customerRepository) => _customerRepository = customerRepository;

        public async Task<Invoice> Handle(DeleteInvoiceCommand request, CancellationToken cancellationToken)
        {
            return await _customerRepository.DeleteAsync(request.Invoice);
        }
    }
}
