namespace Invoice.Profile
{
    using AutoMapper;
    using Invoice.Controllers.Dto;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateInvoiceRequestDto, Domain.Models.Invoice>();
            CreateMap<Domain.Models.Invoice, CreateInvoiceResponseDto>();

            CreateMap<DeleteInvoiceRequestDto, Domain.Models.Invoice>();
            CreateMap<Domain.Models.Invoice, DeleteInvoiceResponseDto>();

            CreateMap<Domain.Models.Invoice, FindInvoiceResponseDto>();
        }
    }
}
