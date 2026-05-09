using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Domain.DTO.Response;

namespace CleanArchitectureCQRS.Application.Queries;

public record ObterClienteQuery(int Id) : IRequest<ClienteResponse>;