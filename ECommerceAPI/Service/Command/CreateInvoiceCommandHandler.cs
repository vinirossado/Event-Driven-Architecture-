using Domain.Models;
using MediatR;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, Invoice>
    {
        private readonly IInvoiceRepository _invoiceRepository;
        public CreateInvoiceCommandHandler(IInvoiceRepository customerRepository) => _invoiceRepository = customerRepository;

        public async Task<Invoice> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
            return await _invoiceRepository.AddAsync(request.Invoice);
        }
    }
}
