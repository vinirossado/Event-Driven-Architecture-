using Domain.Models;
using MediatR;
using Repository.Interface;

namespace Service.Query
{
    public class GetAllInvoiceQueryHandler : IRequestHandler<GetAllInvoiceQuery, List<Invoice>>
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public GetAllInvoiceQueryHandler(IInvoiceRepository invoiceRepository) => _invoiceRepository = invoiceRepository;

        public async Task<List<Invoice>> Handle(GetAllInvoiceQuery request, CancellationToken cancellationToken)
        {
            return _invoiceRepository.GetAll().ToList();
        }
    }
}
