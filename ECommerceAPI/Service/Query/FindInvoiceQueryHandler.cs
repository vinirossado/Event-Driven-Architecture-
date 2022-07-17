using Domain.Models;
using Repository.Interface;

namespace Service.Query
{
    public class FindInvoiceQueryHandler : IRequestHandler<FindInvoiceQuery, Invoice>
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public FindInvoiceQueryHandler(IInvoiceRepository customerRepository)
        {
            _invoiceRepository = customerRepository;
        }
        public async Task<Invoice> Handle(FindInvoiceQuery request, CancellationToken cancellationToken)
        {
            return await _invoiceRepository.GetByIdAsync(request.InvoiceId);    
        }
    }
}
