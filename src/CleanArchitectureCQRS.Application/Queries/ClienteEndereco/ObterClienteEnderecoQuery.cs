using MediatR;
using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.Queries;

public record ObterClienteEnderecoQuery(int Id) : IRequest<ClienteEndereco>;