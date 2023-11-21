using MediatR;
using OPS.Application.DTO.Customer;

namespace OPS.Application.Features.Customer.Queries.GetCustomerDetails;

public record GetCustomerDetailsQuery(int Id) : IRequest<CustomerDetailDto>;