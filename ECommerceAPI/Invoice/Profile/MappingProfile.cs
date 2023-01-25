namespace Invoice.Profile
{
    using AutoMapper;
    using Invoice.Controllers.Dto;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateInvoiceRequestDto, ECommerce.Domain.Models.InvoiceModel>();
            CreateMap<ECommerce.Domain.Models.InvoiceModel, CreateInvoiceResponseDto>();

            CreateMap<DeleteInvoiceRequestDto, ECommerce.Domain.Models.InvoiceModel>();
            CreateMap<ECommerce.Domain.Models.InvoiceModel, DeleteInvoiceResponseDto>();

            CreateMap<ECommerce.Domain.Models.InvoiceModel, FindInvoiceResponseDto>();
        }
    }
}
