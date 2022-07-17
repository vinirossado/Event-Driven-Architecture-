using Domain.Models;
using MediatR;

namespace Service.Query
{
    public class GetAllInvoiceQuery : IRequest<List<Invoice>>
    {
    }
}
