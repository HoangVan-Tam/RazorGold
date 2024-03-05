using System;
using MediatR;
using RazorGold.Application.DTOs.Customer;

namespace RazorGold.Application.Features.Customer.Requests.Queries
{
	public class GetCustomerDetailRequest : IRequest<CustomerDto>
	{
		public int Id { get; set; }
	}
}

