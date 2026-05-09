using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record AlterarPaiCommand(Pai entity) : IRequest<int>;