using System;
using MediatR;
using RazorGold.Application.DTOs.Customer;

namespace RazorGold.Application.Features.Customer.Requests.Queries
{
	public class GetCustomerListRequest : IRequest<List<CustomerDto>>
	{

	}
}

