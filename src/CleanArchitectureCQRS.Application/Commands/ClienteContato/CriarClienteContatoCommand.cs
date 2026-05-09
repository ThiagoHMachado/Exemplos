using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record CriarClienteContatoCommand(ClienteContato entity) : IRequest<int>;