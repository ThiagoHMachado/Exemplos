using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record AlterarClienteContatoCommand(ClienteContato entity) : IRequest<int>;