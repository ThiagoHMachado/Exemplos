using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record AlterarCidadeCommand(Cidade entity) : IRequest<int>;