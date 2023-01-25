using ECommerce.Domain.Interface;

namespace ECommerce.Domain.Models
{
    public class InvoiceModel : IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
