using System.ComponentModel.DataAnnotations;

namespace Invoice.Controllers.Dto
{
    public record CreateInvoiceRequestDto
    {
        [Required]
        [MinLength(6, ErrorMessage = $"{nameof(FirstName)} should have minimum 6 characters")]
        public string FirstName { get; init; }
     
        [Required]
        [MinLength(6, ErrorMessage = $"{nameof(LastName)} should have minimum 6 characters")]
        public string LastName { get; init; }
    }
}
