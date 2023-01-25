using ECommerce.Domain.Models;
using ECommerce.Repository.Interfaces;

namespace ECommerce.Service.Query.Invoice
{
    public class GetAllInvoiceQueryHandler : IRequestHandler<GetAllInvoiceQuery, List<InvoiceModel>>
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public GetAllInvoiceQueryHandler(IInvoiceRepository invoiceRepository) => _invoiceRepository = invoiceRepository;

        public async Task<List<InvoiceModel>> Handle(GetAllInvoiceQuery request, CancellationToken cancellationToken)
        {
            return _invoiceRepository.GetAll().ToList();
        }
    }
}
