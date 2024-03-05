using System;
using AutoMapper;
using MediatR;
using RazorGold.Application.DTOs.Customer;
using RazorGold.Application.Features.Customer.Requests.Queries;
using RazorGold.Application.Persistence.Contracts;

namespace RazorGold.Application.Features.Customer.Handlers.Queries
{
	public class GetCustomerListRequestHandler : IRequestHandler<GetCustomerListRequest, List<CustomerDto>> 
	{
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerListRequestHandler(ICustomerRepository customerRepository, IMapper mapper)
		{
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<List<CustomerDto>> Handle(GetCustomerListRequest request, CancellationToken cancellationToken)
        {
            var customers = await _customerRepository.GetAll();
            return _mapper.Map<List<CustomerDto>>(customers);
        }
    }
}

