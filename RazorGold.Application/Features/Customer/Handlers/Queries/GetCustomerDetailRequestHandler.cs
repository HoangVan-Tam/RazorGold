using System;
using AutoMapper;
using MediatR;
using RazorGold.Application.DTOs.Customer;
using RazorGold.Application.Features.Customer.Requests.Queries;
using RazorGold.Application.Persistence.Contracts;

namespace RazorGold.Application.Features.Customer.Handlers.Queries
{
	public class GetCustomerDetailRequestHandler : IRequestHandler<GetCustomerDetailRequest, CustomerDto>
	{
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerDetailRequestHandler(ICustomerRepository customerRepository, IMapper mapper)
		{
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(GetCustomerDetailRequest request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetAsync(request.Id);
            return _mapper.Map<CustomerDto>(customer);
        }
    }
}

