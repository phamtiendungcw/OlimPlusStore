using MediatR;
using OPS.Application.DTO.Customer;

namespace OPS.Application.Features.Customer.Queries.GetAllCustomers;

public record GetAllCustomersQuery() : IRequest<List<CustomerDto>>;