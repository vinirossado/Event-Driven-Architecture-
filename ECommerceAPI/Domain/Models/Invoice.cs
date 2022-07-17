using Domain.Interface;

namespace Domain.Models
{
    public class Invoice : IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
