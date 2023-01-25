using AutoMapper;
using ECommerce.Domain.Models;
using ECommerce.Service.Command.Invoice;
using ECommerce.Service.Query.Invoice;
using Invoice.Controllers.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.Controllers
{
    [ApiController]
    [Route("Invoice")]
    public class InvoiceController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public InvoiceController(IMediator mediator, IMapper mapper)
        {
            (_mediator, _mapper) = (mediator, mapper);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("GetAll")]
        public async Task<ActionResult<List<GetAllInvoiceResponseDto>>> GetAll()
        {
            try
            {
                var response = await _mediator.Send(new GetAllInvoiceQuery());
                return _mapper.Map<List<GetAllInvoiceResponseDto>>(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("createInvoice")]
        public async Task<ActionResult<CreateInvoiceResponseDto>> Create(CreateInvoiceRequestDto createInvoiceModel)
        {
            try
            {
                var invoice = _mapper.Map<InvoiceModel>(createInvoiceModel);
                var response = await _mediator.Send(new CreateInvoiceCommand
                {
                    Invoice = invoice
                });

                return _mapper.Map<CreateInvoiceResponseDto>(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("DeleteInvoice")]
        public async Task<ActionResult<DeleteInvoiceResponseDto>> Delete(DeleteInvoiceRequestDto deleteCustomerRequest)
        {
            try
            {
                var invoice = _mapper.Map<ECommerce.Domain.Models.InvoiceModel>(deleteCustomerRequest);
                var response = await _mediator.Send(new DeleteInvoiceCommand
                {
                    Invoice = invoice
                });

                return _mapper.Map<DeleteInvoiceResponseDto>(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("FindInvoice")]
        public async Task<ActionResult<FindInvoiceResponseDto>> Find([FromQuery(Name = "id")] Guid invoiceId)
        {
            try
            {
                var response = await _mediator.Send(new FindInvoiceQuery
                {
                    InvoiceId = invoiceId
                });

                return _mapper.Map<FindInvoiceResponseDto>(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
