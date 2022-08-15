using ECommerce.Domain.Models;
using ECommerce.Repository.Interfaces;

namespace ECommerce.Service.Query.Invoice
{
    public class FindInvoiceQueryHandler : IRequestHandler<FindInvoiceQuery, InvoiceModel>
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public FindInvoiceQueryHandler(IInvoiceRepository customerRepository)
        {
            _invoiceRepository = customerRepository;
        }
        public async Task<InvoiceModel> Handle(FindInvoiceQuery request, CancellationToken cancellationToken)
        {
            return await _invoiceRepository.GetByIdAsync(request.InvoiceId);
        }
    }
}
